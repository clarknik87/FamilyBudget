
namespace FamilyBudget
{
    partial class Month_tab
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
            this.tlp_TopLevelRows = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_labelrow = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.tlp_ButtonRow = new System.Windows.Forms.TableLayoutPanel();
            this.btn_removeRow = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.tlp_TopLevelRows.SuspendLayout();
            this.tlp_labelrow.SuspendLayout();
            this.tlp_ButtonRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_TopLevelRows
            // 
            this.tlp_TopLevelRows.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlp_TopLevelRows.ColumnCount = 1;
            this.tlp_TopLevelRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_TopLevelRows.Controls.Add(this.tlp_labelrow, 0, 1);
            this.tlp_TopLevelRows.Controls.Add(this.tlp_ButtonRow, 0, 3);
            this.tlp_TopLevelRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TopLevelRows.Location = new System.Drawing.Point(0, 0);
            this.tlp_TopLevelRows.Name = "tlp_TopLevelRows";
            this.tlp_TopLevelRows.RowCount = 4;
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_TopLevelRows.Size = new System.Drawing.Size(640, 480);
            this.tlp_TopLevelRows.TabIndex = 0;
            // 
            // tlp_labelrow
            // 
            this.tlp_labelrow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_labelrow.ColumnCount = 4;
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.Controls.Add(this.lbl_Category, 3, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Amount, 2, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Description, 1, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Date, 0, 0);
            this.tlp_labelrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_labelrow.Location = new System.Drawing.Point(5, 214);
            this.tlp_labelrow.Name = "tlp_labelrow";
            this.tlp_labelrow.RowCount = 1;
            this.tlp_labelrow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_labelrow.Size = new System.Drawing.Size(630, 26);
            this.tlp_labelrow.TabIndex = 0;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(4, 1);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(94, 24);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(105, 1);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(319, 24);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(431, 1);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(94, 24);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(532, 1);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(94, 24);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_ButtonRow
            // 
            this.tlp_ButtonRow.ColumnCount = 3;
            this.tlp_ButtonRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ButtonRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_ButtonRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_ButtonRow.Controls.Add(this.btn_removeRow, 1, 0);
            this.tlp_ButtonRow.Controls.Add(this.btn_AddRow, 2, 0);
            this.tlp_ButtonRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ButtonRow.Location = new System.Drawing.Point(5, 457);
            this.tlp_ButtonRow.Name = "tlp_ButtonRow";
            this.tlp_ButtonRow.RowCount = 1;
            this.tlp_ButtonRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ButtonRow.Size = new System.Drawing.Size(630, 18);
            this.tlp_ButtonRow.TabIndex = 1;
            // 
            // btn_removeRow
            // 
            this.btn_removeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_removeRow.Location = new System.Drawing.Point(585, 3);
            this.btn_removeRow.Name = "btn_removeRow";
            this.btn_removeRow.Size = new System.Drawing.Size(18, 12);
            this.btn_removeRow.TabIndex = 0;
            this.btn_removeRow.Text = "-";
            this.btn_removeRow.UseVisualStyleBackColor = true;
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddRow.Location = new System.Drawing.Point(609, 3);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(18, 12);
            this.btn_AddRow.TabIndex = 1;
            this.btn_AddRow.Text = "+";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            // 
            // Month_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_TopLevelRows);
            this.Name = "Month_tab";
            this.Size = new System.Drawing.Size(640, 480);
            this.tlp_TopLevelRows.ResumeLayout(false);
            this.tlp_labelrow.ResumeLayout(false);
            this.tlp_labelrow.PerformLayout();
            this.tlp_ButtonRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_TopLevelRows;
        private System.Windows.Forms.TableLayoutPanel tlp_labelrow;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TableLayoutPanel tlp_ButtonRow;
        private System.Windows.Forms.Button btn_removeRow;
        private System.Windows.Forms.Button btn_AddRow;
    }
}
