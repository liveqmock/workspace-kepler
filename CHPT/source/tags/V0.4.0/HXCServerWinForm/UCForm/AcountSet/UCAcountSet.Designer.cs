﻿namespace HXCServerWinForm.UCForm.AcountSet
{
    partial class UCAcountSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAcountSet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccList = new ServiceStationClient.ComponentUI.DataGridViewEx(this.components);
            this.setbook_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setbook_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_main_set_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new ServiceStationClient.ComponentUI.PanelEx();
            this.cmstatus = new ServiceStationClient.ComponentUI.ComboBoxEx(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtsetbook_name = new ServiceStationClient.ComponentUI.TextBoxEx();
            this.txtsetbook_code = new ServiceStationClient.ComponentUI.TextBoxEx();
            this.dtpend = new ServiceStationClient.ComponentUI.DateTimePickerEx_sms();
            this.dtpstart = new ServiceStationClient.ComponentUI.DateTimePickerEx_sms();
            this.btnSearch = new ServiceStationClient.ComponentUI.ButtonEx();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new ServiceStationClient.ComponentUI.ButtonEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccList)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpt
            // 
            this.pnlOpt.Size = new System.Drawing.Size(953, 25);
            // 
            // dgvAccList
            // 
            this.dgvAccList.AllowUserToAddRows = false;
            this.dgvAccList.AllowUserToDeleteRows = false;
            this.dgvAccList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvAccList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setbook_code,
            this.setbook_name,
            this.com_name,
            this.contact,
            this.contact_telephone,
            this.is_main_set_book,
            this.status,
            this.create_time,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccList.EnableHeadersVisualStyles = false;
            this.dgvAccList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.dgvAccList.Location = new System.Drawing.Point(0, 127);
            this.dgvAccList.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dgvAccList.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvAccList.MergeColumnNames")));
            this.dgvAccList.MultiSelect = false;
            this.dgvAccList.Name = "dgvAccList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccList.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(172)))), ((int)(((byte)(138)))));
            this.dgvAccList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccList.RowTemplate.Height = 23;
            this.dgvAccList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccList.ShowCheckBox = true;
            this.dgvAccList.Size = new System.Drawing.Size(953, 417);
            this.dgvAccList.TabIndex = 16;
            this.dgvAccList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccList_CellClick);
            this.dgvAccList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDicList_CellFormatting);
            // 
            // setbook_code
            // 
            this.setbook_code.DataPropertyName = "setbook_code";
            this.setbook_code.FillWeight = 102.6831F;
            this.setbook_code.HeaderText = "帐套代码";
            this.setbook_code.Name = "setbook_code";
            this.setbook_code.ReadOnly = true;
            this.setbook_code.Width = 122;
            // 
            // setbook_name
            // 
            this.setbook_name.DataPropertyName = "setbook_name";
            this.setbook_name.FillWeight = 102.6831F;
            this.setbook_name.HeaderText = "帐套名称";
            this.setbook_name.Name = "setbook_name";
            this.setbook_name.ReadOnly = true;
            this.setbook_name.Width = 160;
            // 
            // com_name
            // 
            this.com_name.DataPropertyName = "com_name";
            this.com_name.FillWeight = 102.6831F;
            this.com_name.HeaderText = "公司名称";
            this.com_name.Name = "com_name";
            this.com_name.ReadOnly = true;
            this.com_name.Width = 160;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.FillWeight = 102.6831F;
            this.contact.HeaderText = "联系人";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 122;
            // 
            // contact_telephone
            // 
            this.contact_telephone.DataPropertyName = "contact_telephone";
            this.contact_telephone.FillWeight = 102.6831F;
            this.contact_telephone.HeaderText = "联系电话";
            this.contact_telephone.Name = "contact_telephone";
            this.contact_telephone.ReadOnly = true;
            this.contact_telephone.Width = 123;
            // 
            // is_main_set_book
            // 
            this.is_main_set_book.DataPropertyName = "is_main_set_book";
            this.is_main_set_book.HeaderText = "是否主账套";
            this.is_main_set_book.Name = "is_main_set_book";
            this.is_main_set_book.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FillWeight = 102.6831F;
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 122;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.FillWeight = 102.6831F;
            this.create_time.HeaderText = "创建时间";
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            this.create_time.Width = 122;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelEx1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelEx1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.panelEx1.BorderWidth = 1;
            this.panelEx1.Controls.Add(this.cmstatus);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.txtsetbook_name);
            this.panelEx1.Controls.Add(this.txtsetbook_code);
            this.panelEx1.Controls.Add(this.dtpend);
            this.panelEx1.Controls.Add(this.dtpstart);
            this.panelEx1.Controls.Add(this.btnSearch);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.btnClear);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.label7);
            this.panelEx1.Curvature = 0;
            this.panelEx1.CurveMode = ((ServiceStationClient.ComponentUI.CornerCurveMode)((((ServiceStationClient.ComponentUI.CornerCurveMode.TopLeft | ServiceStationClient.ComponentUI.CornerCurveMode.TopRight)
                        | ServiceStationClient.ComponentUI.CornerCurveMode.BottomLeft)
                        | ServiceStationClient.ComponentUI.CornerCurveMode.BottomRight)));
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.GradientMode = ServiceStationClient.ComponentUI.LinearGradientMode.None;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(953, 99);
            this.panelEx1.TabIndex = 14;
            // 
            // cmstatus
            // 
            this.cmstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmstatus.FormattingEnabled = true;
            this.cmstatus.Location = new System.Drawing.Point(654, 13);
            this.cmstatus.Name = "cmstatus";
            this.cmstatus.Size = new System.Drawing.Size(121, 22);
            this.cmstatus.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "状态：";
            // 
            // txtsetbook_name
            // 
            this.txtsetbook_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsetbook_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsetbook_name.BackColor = System.Drawing.Color.Transparent;
            this.txtsetbook_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsetbook_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtsetbook_name.ForeImage = null;
            this.txtsetbook_name.Location = new System.Drawing.Point(398, 13);
            this.txtsetbook_name.MaxLengh = 32767;
            this.txtsetbook_name.Multiline = false;
            this.txtsetbook_name.Name = "txtsetbook_name";
            this.txtsetbook_name.Radius = 3;
            this.txtsetbook_name.ReadOnly = false;
            this.txtsetbook_name.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtsetbook_name.ShowError = false;
            this.txtsetbook_name.Size = new System.Drawing.Size(160, 23);
            this.txtsetbook_name.TabIndex = 29;
            this.txtsetbook_name.UseSystemPasswordChar = false;
            this.txtsetbook_name.Value = "";
            this.txtsetbook_name.VerifyCondition = null;
            this.txtsetbook_name.VerifyType = null;
            this.txtsetbook_name.WaterMark = null;
            this.txtsetbook_name.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtsetbook_code
            // 
            this.txtsetbook_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsetbook_code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsetbook_code.BackColor = System.Drawing.Color.Transparent;
            this.txtsetbook_code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsetbook_code.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtsetbook_code.ForeImage = null;
            this.txtsetbook_code.Location = new System.Drawing.Point(78, 13);
            this.txtsetbook_code.MaxLengh = 32767;
            this.txtsetbook_code.Multiline = false;
            this.txtsetbook_code.Name = "txtsetbook_code";
            this.txtsetbook_code.Radius = 3;
            this.txtsetbook_code.ReadOnly = false;
            this.txtsetbook_code.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtsetbook_code.ShowError = false;
            this.txtsetbook_code.Size = new System.Drawing.Size(160, 23);
            this.txtsetbook_code.TabIndex = 29;
            this.txtsetbook_code.UseSystemPasswordChar = false;
            this.txtsetbook_code.Value = "";
            this.txtsetbook_code.VerifyCondition = null;
            this.txtsetbook_code.VerifyType = null;
            this.txtsetbook_code.WaterMark = null;
            this.txtsetbook_code.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // dtpend
            // 
            this.dtpend.Location = new System.Drawing.Point(200, 49);
            this.dtpend.Name = "dtpend";
            this.dtpend.ShowFormat = "yyyy-MM-dd";
            this.dtpend.Size = new System.Drawing.Size(116, 21);
            this.dtpend.TabIndex = 27;
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(78, 49);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.ShowFormat = "yyyy-MM-dd";
            this.dtpstart.Size = new System.Drawing.Size(99, 21);
            this.dtpstart.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Caption = "查询";
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DownImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.DownImage")));
            this.btnSearch.Location = new System.Drawing.Point(856, 49);
            this.btnSearch.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.MoveImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.NormalImage")));
            this.btnSearch.Size = new System.Drawing.Size(76, 26);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "至 ";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Caption = "清除";
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DownImage = ((System.Drawing.Image)(resources.GetObject("btnClear.DownImage")));
            this.btnClear.Location = new System.Drawing.Point(856, 13);
            this.btnClear.MoveImage = ((System.Drawing.Image)(resources.GetObject("btnClear.MoveImage")));
            this.btnClear.Name = "btnClear";
            this.btnClear.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnClear.NormalImage")));
            this.btnClear.Size = new System.Drawing.Size(76, 26);
            this.btnClear.TabIndex = 12;
            this.btnClear.Tag = "1";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "帐套名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "创建时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "帐套代码：";
            // 
            // UCAcountSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAccList);
            this.Controls.Add(this.panelEx1);
            this.Name = "UCAcountSet";
            this.Size = new System.Drawing.Size(953, 544);
            this.Load += new System.EventHandler(this.UCAcountSet_Load);
            this.Controls.SetChildIndex(this.pnlOpt, 0);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.Controls.SetChildIndex(this.dgvAccList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccList)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ServiceStationClient.ComponentUI.DataGridViewEx dgvAccList;
        private ServiceStationClient.ComponentUI.PanelEx panelEx1;
        private ServiceStationClient.ComponentUI.TextBoxEx txtsetbook_name;
        private ServiceStationClient.ComponentUI.TextBoxEx txtsetbook_code;
        private ServiceStationClient.ComponentUI.DateTimePickerEx_sms dtpend;
        private ServiceStationClient.ComponentUI.DateTimePickerEx_sms dtpstart;
        private ServiceStationClient.ComponentUI.ButtonEx btnSearch;
        private System.Windows.Forms.Label label5;
        private ServiceStationClient.ComponentUI.ButtonEx btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private ServiceStationClient.ComponentUI.ComboBoxEx cmstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn setbook_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn setbook_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_main_set_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
