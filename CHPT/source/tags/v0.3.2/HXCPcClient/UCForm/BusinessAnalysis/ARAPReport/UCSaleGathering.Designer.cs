﻿namespace HXCPcClient.UCForm.BusinessAnalysis.ARAPReport
{
    partial class UCSaleGathering
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSaleGathering));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboorg_id = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.cboCompany = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dicreate_time = new ServiceStationClient.ComponentUI.DateInterval();
            this.cboIsMember = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCust_name = new ServiceStationClient.ComponentUI.TextBoxEx();
            this.cboCust_type = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.txtcCust_code = new ServiceStationClient.ComponentUI.TextBox.TextChooser();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReport = new ServiceStationClient.ComponentUI.DataGridViewReport();
            this.col_sale_billing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cboorg_id);
            this.pnlSearch.Controls.Add(this.cboCompany);
            this.pnlSearch.Controls.Add(this.label13);
            this.pnlSearch.Controls.Add(this.label14);
            this.pnlSearch.Controls.Add(this.dicreate_time);
            this.pnlSearch.Controls.Add(this.cboIsMember);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtCust_name);
            this.pnlSearch.Controls.Add(this.cboCust_type);
            this.pnlSearch.Controls.Add(this.txtcCust_code);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.SetChildIndex(this.btnClear, 0);
            this.pnlSearch.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label5, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label6, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label7, 0);
            this.pnlSearch.Controls.SetChildIndex(this.txtcCust_code, 0);
            this.pnlSearch.Controls.SetChildIndex(this.cboCust_type, 0);
            this.pnlSearch.Controls.SetChildIndex(this.txtCust_name, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label2, 0);
            this.pnlSearch.Controls.SetChildIndex(this.cboIsMember, 0);
            this.pnlSearch.Controls.SetChildIndex(this.dicreate_time, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label14, 0);
            this.pnlSearch.Controls.SetChildIndex(this.label13, 0);
            this.pnlSearch.Controls.SetChildIndex(this.cboCompany, 0);
            this.pnlSearch.Controls.SetChildIndex(this.cboorg_id, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.dgvReport);
            // 
            // cboorg_id
            // 
            this.cboorg_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboorg_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboorg_id.FormattingEnabled = true;
            this.cboorg_id.Location = new System.Drawing.Point(786, 71);
            this.cboorg_id.Name = "cboorg_id";
            this.cboorg_id.Size = new System.Drawing.Size(121, 22);
            this.cboorg_id.TabIndex = 244;
            this.cboorg_id.Tag = "a.org_id";
            // 
            // cboCompany
            // 
            this.cboCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(571, 71);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(121, 22);
            this.cboCompany.TabIndex = 243;
            this.cboCompany.SelectedIndexChanged += new System.EventHandler(this.cboCompany_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 240;
            this.label13.Text = "公司：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(739, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 241;
            this.label14.Text = "部门：";
            // 
            // dicreate_time
            // 
            this.dicreate_time.BackColor = System.Drawing.Color.Transparent;
            this.dicreate_time.EndDate = "2014-12-25";
            this.dicreate_time.Location = new System.Drawing.Point(40, 68);
            this.dicreate_time.Name = "dicreate_time";
            this.dicreate_time.ShowFormat = "yyyy-MM-dd";
            this.dicreate_time.Size = new System.Drawing.Size(411, 28);
            this.dicreate_time.StartDate = "2014-12-01";
            this.dicreate_time.TabIndex = 242;
            this.dicreate_time.Tag = "order_date";
            // 
            // cboIsMember
            // 
            this.cboIsMember.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIsMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsMember.FormattingEnabled = true;
            this.cboIsMember.Location = new System.Drawing.Point(786, 24);
            this.cboIsMember.Name = "cboIsMember";
            this.cboIsMember.Size = new System.Drawing.Size(121, 22);
            this.cboIsMember.TabIndex = 239;
            this.cboIsMember.Tag = "is_member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 238;
            this.label2.Text = "是否会员：";
            // 
            // txtCust_name
            // 
            this.txtCust_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCust_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCust_name.BackColor = System.Drawing.Color.Transparent;
            this.txtCust_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCust_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtCust_name.ForeImage = null;
            this.txtCust_name.Location = new System.Drawing.Point(345, 24);
            this.txtCust_name.MaxLengh = 32767;
            this.txtCust_name.Multiline = false;
            this.txtCust_name.Name = "txtCust_name";
            this.txtCust_name.Radius = 3;
            this.txtCust_name.ReadOnly = false;
            this.txtCust_name.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtCust_name.ShowError = false;
            this.txtCust_name.Size = new System.Drawing.Size(121, 23);
            this.txtCust_name.TabIndex = 236;
            this.txtCust_name.Tag = "cust_name";
            this.txtCust_name.UseSystemPasswordChar = false;
            this.txtCust_name.Value = "";
            this.txtCust_name.VerifyCondition = null;
            this.txtCust_name.VerifyType = null;
            this.txtCust_name.WaterMark = null;
            this.txtCust_name.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // cboCust_type
            // 
            this.cboCust_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCust_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCust_type.FormattingEnabled = true;
            this.cboCust_type.Location = new System.Drawing.Point(569, 24);
            this.cboCust_type.Name = "cboCust_type";
            this.cboCust_type.Size = new System.Drawing.Size(123, 22);
            this.cboCust_type.TabIndex = 237;
            this.cboCust_type.Tag = "cust_type";
            // 
            // txtcCust_code
            // 
            this.txtcCust_code.ChooserTypeImage = ServiceStationClient.ComponentUI.TextBox.ChooserType.Default;
            this.txtcCust_code.Location = new System.Drawing.Point(104, 23);
            this.txtcCust_code.Name = "txtcCust_code";
            this.txtcCust_code.ReadOnly = false;
            this.txtcCust_code.Size = new System.Drawing.Size(121, 24);
            this.txtcCust_code.TabIndex = 235;
            this.txtcCust_code.Tag = "cust_code";
            this.txtcCust_code.ToolTipTitle = "";
            this.txtcCust_code.ChooserClick += new System.EventHandler(this.txtcCust_code_ChooserClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 234;
            this.label7.Text = "客户类别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 233;
            this.label6.Text = "客户名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 232;
            this.label5.Text = "客户编码：";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sale_billing_id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dgvReport.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvReport.MergeColumnNames")));
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReport.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvReport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReport.RowTemplate.Height = 23;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1069, 379);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellDoubleClick);
            // 
            // col_sale_billing_id
            // 
            this.col_sale_billing_id.DataPropertyName = "sale_billing_id";
            this.col_sale_billing_id.HeaderText = "ID";
            this.col_sale_billing_id.Name = "col_sale_billing_id";
            this.col_sale_billing_id.ReadOnly = true;
            this.col_sale_billing_id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "order_type";
            this.Column1.HeaderText = "单据类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "order_num";
            this.Column2.HeaderText = "单据编码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "order_date";
            this.Column3.HeaderText = "单据日期";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "allmoney";
            this.Column4.HeaderText = "销售金额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "money";
            this.Column5.HeaderText = "已结算金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "waitmoney";
            this.Column6.HeaderText = "未结算金额";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "receipt_type_name";
            this.Column7.HeaderText = "发票类型";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "receivables_date";
            this.Column8.HeaderText = "收款日期";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "current_collect";
            this.Column9.HeaderText = "现收金额";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "balance_way_name";
            this.Column10.HeaderText = "结算方式";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "balance_account_name";
            this.Column11.HeaderText = "结算账户";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "trans_way_name";
            this.Column12.HeaderText = "运输方式";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 80;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "whythe_discount";
            this.Column13.HeaderText = "整单折扣";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Width = 80;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "cust_arrears";
            this.Column14.HeaderText = "客户欠款";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "receivables_limit";
            this.Column15.HeaderText = "收款期限";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column15.Width = 80;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "delivery_address";
            this.Column16.HeaderText = "送货地址";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "org_name";
            this.Column17.HeaderText = "部门";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column17.Width = 80;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "handle_name";
            this.Column18.HeaderText = "经办人";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column18.Width = 80;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "operator_name";
            this.Column19.HeaderText = "操作人";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column19.Width = 80;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "remark";
            this.Column20.HeaderText = "备注";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UCSaleGathering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UCSaleGathering";
            this.Load += new System.EventHandler(this.UCSaleGathering_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceStationClient.ComponentUI.ComboBoxEx cboorg_id;
        private ServiceStationClient.ComponentUI.ComboBoxEx cboCompany;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private ServiceStationClient.ComponentUI.DateInterval dicreate_time;
        private ServiceStationClient.ComponentUI.ComboBoxEx cboIsMember;
        private System.Windows.Forms.Label label2;
        private ServiceStationClient.ComponentUI.TextBoxEx txtCust_name;
        private ServiceStationClient.ComponentUI.ComboBoxEx cboCust_type;
        private ServiceStationClient.ComponentUI.TextBox.TextChooser txtcCust_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ServiceStationClient.ComponentUI.DataGridViewReport dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sale_billing_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
    }
}
