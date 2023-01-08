
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_DescriptionCell = new System.Windows.Forms.TextBox();
            this.mtb_AmountCell = new System.Windows.Forms.MaskedTextBox();
            this.lb_CategoryCell = new System.Windows.Forms.ListBox();
            this.mtb_DateCell = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.tableLayoutPanel1.Controls.Add(this.tb_DescriptionCell, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtb_AmountCell, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_CategoryCell, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mtb_DateCell, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_DescriptionCell
            // 
            this.tb_DescriptionCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DescriptionCell.Location = new System.Drawing.Point(111, 3);
            this.tb_DescriptionCell.Name = "tb_DescriptionCell";
            this.tb_DescriptionCell.Size = new System.Drawing.Size(307, 20);
            this.tb_DescriptionCell.TabIndex = 1;
            // 
            // mtb_AmountCell
            // 
            this.mtb_AmountCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_AmountCell.Location = new System.Drawing.Point(424, 3);
            this.mtb_AmountCell.Name = "mtb_AmountCell";
            this.mtb_AmountCell.Size = new System.Drawing.Size(102, 20);
            this.mtb_AmountCell.TabIndex = 2;
            // 
            // lb_CategoryCell
            // 
            this.lb_CategoryCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CategoryCell.FormattingEnabled = true;
            this.lb_CategoryCell.Location = new System.Drawing.Point(532, 3);
            this.lb_CategoryCell.Name = "lb_CategoryCell";
            this.lb_CategoryCell.Size = new System.Drawing.Size(105, 18);
            this.lb_CategoryCell.TabIndex = 3;
            // 
            // mtb_DateCell
            // 
            this.mtb_DateCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_DateCell.Location = new System.Drawing.Point(3, 3);
            this.mtb_DateCell.Name = "mtb_DateCell";
            this.mtb_DateCell.Size = new System.Drawing.Size(102, 20);
            this.mtb_DateCell.TabIndex = 4;
            // 
            // Row_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Row_item";
            this.Size = new System.Drawing.Size(640, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_DescriptionCell;
        private System.Windows.Forms.MaskedTextBox mtb_AmountCell;
        private System.Windows.Forms.ListBox lb_CategoryCell;
        private System.Windows.Forms.MaskedTextBox mtb_DateCell;
    }
}
