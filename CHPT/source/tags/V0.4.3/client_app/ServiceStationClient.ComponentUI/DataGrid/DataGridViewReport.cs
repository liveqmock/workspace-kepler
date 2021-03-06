﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Runtime.InteropServices;
using System.Drawing.Design;

namespace ServiceStationClient.ComponentUI
{
    public partial class DataGridViewReport : DataGridView
    {
        private bool showNum = true;
        private bool PaintFlag = false;
        public DataGridViewReport()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            Paint += delegate
            {
                if (!PaintFlag)
                {
                    SetDataGridViewStyle(this);
                    PaintFlag = true;
                }
            };
        }

        /// <summary>
        /// 设置数据表格样式,并将最后一列填充其余空白
        /// </summary>
        /// <param name="dgv">数据表格</param>
        /// <param name="column">最后一列</param>
        public static void SetDataGridViewStyle(DataGridViewReport dgv, DataGridViewColumn column)
        {
            if (column != null) column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  //最后一列填充
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = ColorTranslator.FromHtml("#f1fdfc");
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 241, 243);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //选中行颜色
            dataGridViewCellStyle3.SelectionBackColor = ColorTranslator.FromHtml("#cceaff");
            dataGridViewCellStyle3.Font = new Font("宋体", 9F, FontStyle.Regular);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.BackColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv.GridColor = Color.FromArgb(221, 221, 221);

            //序号列样式-行标题背景色 选中色
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 236, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 236, 255);
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            //行标题边框样式
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }
        /// <summary>
        /// 设置数据表格样式
        /// </summary>
        /// <param name="dgv">数据表格</param>
        public static void SetDataGridViewStyle(DataGridViewReport dgv)
        {
            SetDataGridViewStyle(dgv, null);
        }

        public void SetDefaultStyle()
        {
            this.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f1fdfc");
            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#cceaff");
            this.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#cceaff");
            this.RowHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#cceaff");
        }

        [DefaultValue(true), Description("是否显示行号")]
        public bool ShowNum
        {
            get
            {
                return showNum;
            }
            set
            {
                showNum = value;
                if (value)
                {
                    this.RowHeadersVisible = true;
                }
            }
        }


        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            if (ShowNum)
            {
                this.RowHeadersVisible = true;
                SolidBrush solidBrush = new SolidBrush(Color.Black);
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            }
            base.OnRowPostPaint(e);
        }

        protected override void OnScroll(ScrollEventArgs e)
        {
            this.ReDrawHead();
            base.OnScroll(e);
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                #region 不含合并列标题背景
                if (e.RowIndex == -1)
                {
                    if (!this.SpanRows.ContainsKey(e.ColumnIndex))
                    {
                        int X = e.CellBounds.X;
                        int Y = e.CellBounds.Y;
                        int W = e.CellBounds.Width;
                        int H = e.CellBounds.Height;

                        using (Pen blackPen = new Pen(Color.FromArgb(221, 221, 221))) //(163, 192, 232)))//边框颜色
                        {
                            using(SolidBrush sb=new SolidBrush (ColorTranslator.FromHtml("#e1f0fc")))
                            {
                                e.Graphics.FillRectangle(sb, new Rectangle(X, Y, W, H));
                            }
                            if (e.ColumnIndex == 0)
                                e.Graphics.DrawRectangle(blackPen, new Rectangle(X, Y + 1, W - 1, H - 2));
                            else
                                e.Graphics.DrawRectangle(blackPen, new Rectangle(X - 1, Y + 1, W, H - 2));
                            e.PaintContent(e.CellBounds);
                            e.Handled = true;
                        }
                    }
                }
                #endregion
                #region 合并列标题背景
                if (((e.RowIndex <= -1) || (e.ColumnIndex <= -1)) && ((e.RowIndex == -1) && this.SpanRows.ContainsKey(e.ColumnIndex)))
                {
                    Graphics graphics = e.Graphics;
                    e.Paint(e.CellBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.Background);
                    int left = e.CellBounds.Left;
                    int y = e.CellBounds.Top + 2;
                    int right = e.CellBounds.Right;
                    int bottom = e.CellBounds.Bottom;
                    switch (this.SpanRows[e.ColumnIndex].Position)
                    {
                        case 1:
                            left += 2;
                            break;

                        case 3:
                            right -= 2;
                            break;
                    }
                    using (SolidBrush sb = new SolidBrush(ColorTranslator.FromHtml("#e1f0fc")))
                    {
                        graphics.FillRectangle(sb, new Rectangle(left, y, right - left, (bottom - y) / 2));
                        graphics.FillRectangle(sb, new Rectangle(left, y, right - left, (bottom - y)));
                    }
                    using (Pen blackPen = new Pen(Color.FromArgb(221, 221, 221))) //(163, 192, 232)))//边框颜色
                    {
                        e.Graphics.DrawRectangle(blackPen, new Rectangle(left - 1, y + (bottom - y) / 2, right - left, (bottom - y) / 2));
                    }
                    //graphics.FillRectangle(new SolidBrush(this._mergecolumnheaderbackcolor), left, y, right - left, (bottom - y) / 2);
                    graphics.DrawLine(new Pen(base.GridColor), left, (y + bottom) / 2, right, (y + bottom) / 2);
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    //graphics.DrawString("",e.CellStyle.Font,Brushes.Black,
                    graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Black, new RectangleF(left, (y + bottom) / 2, right - left, (bottom - y) / 2), format);
                    left = base.GetColumnDisplayRectangle(this.SpanRows[e.ColumnIndex].Left, true).Left - 2;
                    if (left < 0)
                    {
                        left = base.GetCellDisplayRectangle(-1, -1, true).Width;
                    }
                    right = base.GetColumnDisplayRectangle(this.SpanRows[e.ColumnIndex].Right, true).Right - 2;
                    if (right < 0)
                    {
                        right = base.Width;
                    }
                    graphics.DrawString(this.SpanRows[e.ColumnIndex].Text, e.CellStyle.Font, Brushes.Black, new Rectangle(left, y, right - left, (bottom - y) / 2), format);

                    e.Handled = true;
                }
                base.OnCellPainting(e);
                #endregion
            }
            catch
            {
            }
        }

        #region 二维表头
        private Color _mergecolumnheaderbackcolor = SystemColors.Control;
        private List<string> _mergecolumnname = new List<string>();
        private Dictionary<int, SpanInfo> SpanRows = new Dictionary<int, SpanInfo>();
        public void AddSpanHeader(int ColIndex, int ColCount, string Text)
        {
            if (ColCount < 2)
            {
                throw new Exception("行宽应大于等于2，合并1列无意义。");
            }
            int right = (ColIndex + ColCount) - 1;
            this.SpanRows[ColIndex] = new SpanInfo(Text, 1, ColIndex, right);
            this.SpanRows[right] = new SpanInfo(Text, 3, ColIndex, right);
            for (int i = ColIndex + 1; i < right; i++)
            {
                this.SpanRows[i] = new SpanInfo(Text, 2, ColIndex, right);
            }
        }

        public void ClearSpanInfo()
        {
            this.SpanRows.Clear();
        }

        private void DrawCell(DataGridViewCellPaintingEventArgs e)
        {
            if (e.CellStyle.Alignment == DataGridViewContentAlignment.NotSet)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Brush brush = new SolidBrush(base.GridColor);
            SolidBrush brush2 = new SolidBrush(e.CellStyle.BackColor);
            SolidBrush brush3 = new SolidBrush(e.CellStyle.ForeColor);
            int upRows = 0;
            int downRows = 0;
            int count = 0;
            if (this.MergeColumnNames.Contains(base.Columns[e.ColumnIndex].Name) && (e.RowIndex != -1))
            {
                int width = e.CellBounds.Width;
                Pen pen = new Pen(brush);
                string str = (e.Value == null) ? "" : e.Value.ToString().Trim();
                if (base.CurrentRow.Cells[e.ColumnIndex].Value != null)
                {
                    base.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Trim();
                }
                if (!string.IsNullOrEmpty(str))
                {
                    for (int i = e.RowIndex; i < base.Rows.Count; i++)
                    {
                        if (!base.Rows[i].Cells[e.ColumnIndex].Value.ToString().Equals(str))
                        {
                            break;
                        }
                        downRows++;
                        if (e.RowIndex != i)
                        {
                            width = (width < base.Rows[i].Cells[e.ColumnIndex].Size.Width) ? width : base.Rows[i].Cells[e.ColumnIndex].Size.Width;
                        }
                    }
                    for (int j = e.RowIndex; j >= 0; j--)
                    {
                        if (!base.Rows[j].Cells[e.ColumnIndex].Value.ToString().Equals(str))
                        {
                            break;
                        }
                        upRows++;
                        if (e.RowIndex != j)
                        {
                            width = (width < base.Rows[j].Cells[e.ColumnIndex].Size.Width) ? width : base.Rows[j].Cells[e.ColumnIndex].Size.Width;
                        }
                    }
                    count = (downRows + upRows) - 1;
                    if (count < 2)
                    {
                        return;
                    }
                }
                if (base.Rows[e.RowIndex].Selected)
                {
                    brush2.Color = e.CellStyle.SelectionBackColor;
                    brush3.Color = e.CellStyle.SelectionForeColor;
                }
                e.Graphics.FillRectangle(brush2, e.CellBounds);
                this.PaintingFont(e, width, upRows, downRows, count);
                if (downRows == 1)
                {
                    e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    count = 0;
                }
                e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                e.Handled = true;
            }
        }
        private void PaintingFont(DataGridViewCellPaintingEventArgs e, int cellwidth, int UpRows, int DownRows, int count)
        {
            SolidBrush brush = new SolidBrush(e.CellStyle.ForeColor);
            int height = (int)e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font).Height;
            int width = (int)e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font).Width;
            int num3 = e.CellBounds.Height;
            if (e.CellStyle.Alignment == DataGridViewContentAlignment.BottomCenter)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)(e.CellBounds.X + ((cellwidth - width) / 2)), (float)((e.CellBounds.Y + (num3 * DownRows)) - height));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.BottomLeft)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)e.CellBounds.X, (float)((e.CellBounds.Y + (num3 * DownRows)) - height));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.BottomRight)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)((e.CellBounds.X + cellwidth) - width), (float)((e.CellBounds.Y + (num3 * DownRows)) - height));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.MiddleCenter)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)(e.CellBounds.X + ((cellwidth - width) / 2)), (float)((e.CellBounds.Y - (num3 * (UpRows - 1))) + (((num3 * count) - height) / 2)));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.MiddleLeft)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)e.CellBounds.X, (float)((e.CellBounds.Y - (num3 * (UpRows - 1))) + (((num3 * count) - height) / 2)));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)((e.CellBounds.X + cellwidth) - width), (float)((e.CellBounds.Y - (num3 * (UpRows - 1))) + (((num3 * count) - height) / 2)));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.TopCenter)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)(e.CellBounds.X + ((cellwidth - width) / 2)), (float)(e.CellBounds.Y - (num3 * (UpRows - 1))));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.TopLeft)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)e.CellBounds.X, (float)(e.CellBounds.Y - (num3 * (UpRows - 1))));
            }
            else if (e.CellStyle.Alignment == DataGridViewContentAlignment.TopRight)
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)((e.CellBounds.X + cellwidth) - width), (float)(e.CellBounds.Y - (num3 * (UpRows - 1))));
            }
            else
            {
                e.Graphics.DrawString((string)e.Value, e.CellStyle.Font, brush, (float)(e.CellBounds.X + ((cellwidth - width) / 2)), (float)((e.CellBounds.Y - (num3 * (UpRows - 1))) + (((num3 * count) - height) / 2)));
            }
        }

        public void ReDrawHead()
        {
            foreach (int num in this.SpanRows.Keys)
            {
                base.Invalidate(base.GetCellDisplayRectangle(num, -1, true));
            }
        }

        [Category("二维表头"), Browsable(true), Description("二维表头的背景颜色")]
        public Color MergeColumnHeaderBackColor
        {
            get
            {
                return this._mergecolumnheaderbackcolor;
            }
            set
            {
                this._mergecolumnheaderbackcolor = value;
            }
        }

        [MergableProperty(false), Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Localizable(true), Description("设置或获取合并列的集合"), Browsable(true), Category("单元格合并")]
        public List<string> MergeColumnNames
        {
            get
            {
                return this._mergecolumnname;
            }
            set
            {
                this._mergecolumnname = value;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SpanInfo
        {
            public string Text;
            public int Position;
            public int Left;
            public int Right;
            public SpanInfo(string Text, int Position, int Left, int Right)
            {
                this.Text = Text;
                this.Position = Position;
                this.Left = Left;
                this.Right = Right;
            }
        }
        #endregion

    }
}
