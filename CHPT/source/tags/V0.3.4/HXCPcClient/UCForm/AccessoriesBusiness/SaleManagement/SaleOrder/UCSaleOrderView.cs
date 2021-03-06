﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using SYSModel;
using Utility.Common;
using HXCPcClient.CommonClass;
using ServiceStationClient.ComponentUI;

namespace HXCPcClient.UCForm.AccessoriesBusiness.SaleManagement.SaleOrder
{
    public partial class UCSaleOrderView : UCBase
    {
        #region 变量
        string SaleorderId = string.Empty;
        UCSaleOrderManager uc;
        tb_parts_sale_order tb_partspurchaseorder_Model = new tb_parts_sale_order();
        #endregion

        public UCSaleOrderView(string sale_order_id, string order_status, UCSaleOrderManager uc)
        {
            InitializeComponent();
            base.SetBaseButtonStatus();
            base.SetButtonVisiableView();
            base.btnSave.Visible = true;
            this.SaleorderId = sale_order_id;
            this.uc = uc;

            string[] NotReadOnlyColumnsName = new string[] { "colCheck", "is_suspend" };
            CommonFuncCall.SetColumnReadOnly(gvPurchaseList, NotReadOnlyColumnsName);

            //当采购订单状态是已审核时才可以中止，否则不可以中止
            DataSources.EnumAuditStatus enumDataSources = (DataSources.EnumAuditStatus)Convert.ToInt16(order_status);
            if (enumDataSources != DataSources.EnumAuditStatus.AUDIT)
            {
                chkis_suspend.Enabled = false;
                is_suspend.ReadOnly = true;
            }

            //CommonFuncCall.BindUnit(unit_id);

            LoadInfo(sale_order_id);
            GetAccessories(sale_order_id);
            base.SaveEvent += new ClickHandler(UCSaleOrderView_SaveEvent);
        }

        void UCSaleOrderView_SaveEvent(object sender, EventArgs e)
        {
            try
            {
                List<SysSQLString> listSql = new List<SysSQLString>();
                SysSQLString sysStringSql = new SysSQLString();
                sysStringSql.cmdType = CommandType.Text;
                Dictionary<string, string> dic = new Dictionary<string, string>();//参数

                string sql1 = string.Format(@" Update tb_parts_sale_order Set is_suspend=@is_suspend,suspend_reason=@suspend_reason,update_by=@update_by,
                update_name=@update_name,update_time=@update_time,operators=@operators,operator_name=@operator_name where sale_order_id=@sale_order_id;");
                dic.Add("is_suspend", chkis_suspend.Checked ? "0" : "1");//选中(中止)：0,未选中(不中止)：1
                dic.Add("suspend_reason", txtsuspend_reason.Caption.Trim());
                dic.Add("update_by", GlobalStaticObj.UserID);
                dic.Add("update_name", GlobalStaticObj.UserName);
                dic.Add("update_time", Common.LocalDateTimeToUtcLong(DateTime.Now).ToString());
                dic.Add("operators", GlobalStaticObj.UserID);
                dic.Add("operator_name", GlobalStaticObj.UserName);
                dic.Add("sale_order_id", SaleorderId);
                sysStringSql.sqlString = sql1;
                sysStringSql.Param = dic;
                listSql.Add(sysStringSql);
                foreach (DataGridViewRow dr in gvPurchaseList.Rows)
                {
                    string is_suspend = "1";
                    if (dr.Cells["is_suspend"].Value == null)
                    { is_suspend = "1"; }
                    if ((bool)dr.Cells["is_suspend"].EditedFormattedValue)
                    { is_suspend = "0"; }
                    else
                    { is_suspend = "1"; }

                    sysStringSql = new SysSQLString();
                    sysStringSql.cmdType = CommandType.Text;
                    dic = new Dictionary<string, string>();
                    dic.Add("is_suspend", is_suspend);
                    dic.Add("sale_order_id", SaleorderId);
                    dic.Add("parts_code", dr.Cells["parts_code"].Value.ToString());
                    string sql2 = "Update tb_parts_sale_order_p set is_suspend=@is_suspend where sale_order_id=@sale_order_id and parts_code=@parts_code;";
                    sysStringSql.sqlString = sql2;
                    sysStringSql.Param = dic;
                    listSql.Add(sysStringSql);
                }
                if (DBHelper.BatchExeSQLStringMultiByTrans("修改采购订单", listSql))
                {
                    MessageBoxEx.Show("保存成功！");
                    uc.BindgvSaleOrderList();
                    deleteMenuByTag(this.Tag.ToString(), uc.Name);
                }
                else
                {
                    MessageBoxEx.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("操作失败！");
            }
        }

        /// <summary>
        /// 加载采购计划信息和配件信息
        /// </summary>
        /// <param name="sale_order_id"></param>
        private void LoadInfo(string sale_order_id)
        {
            if (!string.IsNullOrEmpty(sale_order_id))
            {
                //1.查看一条采购订单信息
                DataTable dt = DBHelper.GetTable("查看一条采购订单信息", "tb_parts_sale_order", "*", " sale_order_id='" + sale_order_id + "'", "", "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    CommonFuncCall.SetModlByDataTable(tb_partspurchaseorder_Model, dt);
                    CommonFuncCall.SetShowControlValue(this, tb_partspurchaseorder_Model, "");
                    chkis_suspend.Checked = tb_partspurchaseorder_Model.is_suspend == "0";//选中(中止)：0,未选中(不中止)：1
                    if (!string.IsNullOrEmpty(lblorder_date.Text))
                    {
                        long ticks = Convert.ToInt64(lblorder_date.Text);
                        lblorder_date.Text = Common.UtcLongToLocalDateTime(ticks).ToString();
                    }
                    if (!string.IsNullOrEmpty(lblvalid_till.Text))
                    {
                        long ticks = Convert.ToInt64(lblvalid_till.Text);
                        lblvalid_till.Text = Common.UtcLongToLocalDateTime(ticks).ToString();
                    }
                    if (!string.IsNullOrEmpty(lbldelivery_time.Text))
                    {
                        long ticks = Convert.ToInt64(lbldelivery_time.Text);
                        lbldelivery_time.Text = Common.UtcLongToLocalDateTime(ticks).ToString();
                    }
                    lblcreate_time.Text = Common.UtcLongToLocalDateTime(Convert.ToInt64(tb_partspurchaseorder_Model.create_time.ToString())).ToString();
                    if (tb_partspurchaseorder_Model.update_time > 0)
                    { lblupdate_time.Text = Common.UtcLongToLocalDateTime(Convert.ToInt64(tb_partspurchaseorder_Model.update_time.ToString())).ToString(); }
                }
            }
        }
        /// <summary> 
        /// 根据采购订单号获取采购配件信息
        /// </summary>
        /// <param name="sale_order_id"></param>
        private void GetAccessories(string sale_order_id)
        {
            string conId = string.Empty;
            DataTable dt_parts_purchase = DBHelper.GetTable("查询采购订单单配件表信息", "tb_parts_sale_order_p", "*", " sale_order_id='" + sale_order_id + "'", "", "");
            if (dt_parts_purchase != null && dt_parts_purchase.Rows.Count > 0)
            {
                foreach (DataRow dr in dt_parts_purchase.Rows)
                {
                    DataGridViewRow dgvr = gvPurchaseList.Rows[gvPurchaseList.Rows.Add()];
                    dgvr.Cells["parts_code"].Value = dr["parts_code"];
                    dgvr.Cells["parts_name"].Value = dr["parts_name"];
                    dgvr.Cells["drawing_num"].Value = dr["drawing_num"];
                    dgvr.Cells["unit_name"].Value = dr["unit_name"];
                    dgvr.Cells["parts_brand_name"].Value = dr["parts_brand_name"];
                    dgvr.Cells["business_count"].Value = dr["business_count"];
                    dgvr.Cells["original_price"].Value = dr["original_price"];
                    dgvr.Cells["discount"].Value = dr["discount"];
                    dgvr.Cells["business_price"].Value = dr["business_price"];
                    dgvr.Cells["tax_rate"].Value = dr["tax_rate"];
                    dgvr.Cells["tax"].Value = dr["tax"];
                    dgvr.Cells["payment"].Value = dr["payment"];
                    dgvr.Cells["valorem_together"].Value = dr["valorem_together"];
                    dgvr.Cells["auxiliary_count"].Value = dr["auxiliary_count"];
                    dgvr.Cells["relation_order"].Value = dr["relation_order"];
                    dgvr.Cells["is_gift"].Value = dr["is_gift"];
                    dgvr.Cells["is_suspend"].Value = dr["is_suspend"];

                    dgvr.Cells["delivery_time"].Value = Common.UtcLongToLocalDateTime(Convert.ToInt64(dr["delivery_time"]));
                    dgvr.Cells["remark"].Value = dr["remark"];

                    //dgvr.Cells[""].Value = dr[""];//条码
                    //dgvr.Cells[""].Value = dr[""];//厂商编码

                    dgvr.Cells["create_by"].Value = dr["create_by"];
                    dgvr.Cells["create_name"].Value = dr["create_name"];
                    dgvr.Cells["create_time"].Value = Common.UtcLongToLocalDateTime(Convert.ToInt64(dr["create_time"].ToString()));
                }
            }
        }
        void IsDataGridViewCheckBox(bool ischeck)
        {
            gvPurchaseList.EndEdit();
            if (gvPurchaseList.Rows.Count > 0)
            {
                for (int i = 0; i < gvPurchaseList.Rows.Count; i++)
                {
                    ((DataGridViewCheckBoxCell)gvPurchaseList.Rows[i].Cells["is_suspend"]).Value = ischeck;
                }
            }
        }

        private void chkis_suspend_Click(object sender, EventArgs e)
        {
            txtsuspend_reason.Enabled = chkis_suspend.Checked;
            IsDataGridViewCheckBox(chkis_suspend.Checked);
        }

        private void gvPurchaseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)//双击表头或列头时不起作用   
                {
                    bool isChkis_Suspend = true;
                    bool istxtsuspend_reasonEnable = false;
                    //获取控件的值
                    for (int i = 0; i < gvPurchaseList.Rows.Count; i++)
                    {
                        object ischeck = gvPurchaseList.Rows[i].Cells["is_suspend"].EditedFormattedValue;
                        if (ischeck != null && !(bool)ischeck)
                        {
                            isChkis_Suspend = false;
                            break;
                        }
                    }
                    for (int i = 0; i < gvPurchaseList.Rows.Count; i++)
                    {
                        object ischeck = gvPurchaseList.Rows[i].Cells["is_suspend"].EditedFormattedValue;
                        if (ischeck != null && (bool)ischeck)
                        {
                            istxtsuspend_reasonEnable = true;
                            break;
                        }
                    }
                    chkis_suspend.Checked = isChkis_Suspend;
                    txtsuspend_reason.Enabled = istxtsuspend_reasonEnable;
                }
            }
            catch (Exception ex)
            { }
        }

        private void gvPurchaseList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
    }
}
