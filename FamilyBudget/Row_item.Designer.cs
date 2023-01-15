
namespace FamilyBudget
{
    partial class Row_item
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_CellColumns = new System.Windows.Forms.TableLayoutPanel();
            this.tb_DescriptionCell = new System.Windows.Forms.TextBox();
            this.mtb_AmountCell = new System.Windows.Forms.MaskedTextBox();
            this.mtb_DateCell = new System.Windows.Forms.MaskedTextBox();
            this.lb_CategoryCell = new System.Windows.Forms.ComboBox();
            this.tlp_CellColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_CellColumns
            // 
            this.tlp_CellColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_CellColumns.ColumnCount = 4;
            this.tlp_CellColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_CellColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlp_CellColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_CellColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_CellColumns.Controls.Add(this.tb_DescriptionCell, 1, 0);
            this.tlp_CellColumns.Controls.Add(this.mtb_AmountCell, 2, 0);
            this.tlp_CellColumns.Controls.Add(this.mtb_DateCell, 0, 0);
            this.tlp_CellColumns.Controls.Add(this.lb_CategoryCell, 3, 0);
            this.tlp_CellColumns.Location = new System.Drawing.Point(0, 0);
            this.tlp_CellColumns.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_CellColumns.Name = "tlp_CellColumns";
            this.tlp_CellColumns.RowCount = 1;
            this.tlp_CellColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_CellColumns.Size = new System.Drawing.Size(640, 24);
            this.tlp_CellColumns.TabIndex = 0;
            // 
            // tb_DescriptionCell
            // 
            this.tb_DescriptionCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DescriptionCell.Location = new System.Drawing.Point(102, 0);
            this.tb_DescriptionCell.Margin = new System.Windows.Forms.Padding(0);
            this.tb_DescriptionCell.Name = "tb_DescriptionCell";
            this.tb_DescriptionCell.Size = new System.Drawing.Size(332, 20);
            this.tb_DescriptionCell.TabIndex = 1;
            // 
            // mtb_AmountCell
            // 
            this.mtb_AmountCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_AmountCell.Location = new System.Drawing.Point(434, 0);
            this.mtb_AmountCell.Margin = new System.Windows.Forms.Padding(0);
            this.mtb_AmountCell.Name = "mtb_AmountCell";
            this.mtb_AmountCell.Size = new System.Drawing.Size(102, 20);
            this.mtb_AmountCell.TabIndex = 2;
            // 
            // mtb_DateCell
            // 
            this.mtb_DateCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_DateCell.Location = new System.Drawing.Point(0, 0);
            this.mtb_DateCell.Margin = new System.Windows.Forms.Padding(0);
            this.mtb_DateCell.Name = "mtb_DateCell";
            this.mtb_DateCell.Size = new System.Drawing.Size(102, 20);
            this.mtb_DateCell.TabIndex = 0;
            // 
            // lb_CategoryCell
            // 
            this.lb_CategoryCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CategoryCell.FormattingEnabled = true;
            this.lb_CategoryCell.Location = new System.Drawing.Point(536, 0);
            this.lb_CategoryCell.Margin = new System.Windows.Forms.Padding(0);
            this.lb_CategoryCell.MaxDropDownItems = 16;
            this.lb_CategoryCell.Name = "lb_CategoryCell";
            this.lb_CategoryCell.Size = new System.Drawing.Size(104, 21);
            this.lb_CategoryCell.TabIndex = 3;
            this.lb_CategoryCell.Leave += new System.EventHandler(this.lb_CategoryCell_Leave);
            // 
            // Row_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_CellColumns);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "Row_item";
            this.Size = new System.Drawing.Size(640, 24);
            this.tlp_CellColumns.ResumeLayout(false);
            this.tlp_CellColumns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_CellColumns;
        public System.Windows.Forms.MaskedTextBox mtb_DateCell;
        public System.Windows.Forms.TextBox tb_DescriptionCell;
        public System.Windows.Forms.MaskedTextBox mtb_AmountCell;
        public System.Windows.Forms.ComboBox lb_CategoryCell;
    }
}
