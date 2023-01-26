
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
            this.btn_CategorySort = new System.Windows.Forms.Button();
            this.btn_AmountSort = new System.Windows.Forms.Button();
            this.btn_DescriptionSort = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_DateSort = new System.Windows.Forms.Button();
            this.tlp_ButtonRow = new System.Windows.Forms.TableLayoutPanel();
            this.btn_removeRow = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.tlp_ItemRows = new System.Windows.Forms.TableLayoutPanel();
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
            this.tlp_TopLevelRows.Controls.Add(this.tlp_ItemRows, 0, 2);
            this.tlp_TopLevelRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TopLevelRows.Location = new System.Drawing.Point(0, 0);
            this.tlp_TopLevelRows.Name = "tlp_TopLevelRows";
            this.tlp_TopLevelRows.RowCount = 4;
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_TopLevelRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_TopLevelRows.Size = new System.Drawing.Size(640, 480);
            this.tlp_TopLevelRows.TabIndex = 0;
            // 
            // tlp_labelrow
            // 
            this.tlp_labelrow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_labelrow.ColumnCount = 8;
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp_labelrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_labelrow.Controls.Add(this.btn_CategorySort, 7, 0);
            this.tlp_labelrow.Controls.Add(this.btn_AmountSort, 5, 0);
            this.tlp_labelrow.Controls.Add(this.btn_DescriptionSort, 3, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Category, 6, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Amount, 4, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Description, 2, 0);
            this.tlp_labelrow.Controls.Add(this.lbl_Date, 0, 0);
            this.tlp_labelrow.Controls.Add(this.btn_DateSort, 1, 0);
            this.tlp_labelrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_labelrow.Location = new System.Drawing.Point(5, 169);
            this.tlp_labelrow.Name = "tlp_labelrow";
            this.tlp_labelrow.RowCount = 1;
            this.tlp_labelrow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_labelrow.Size = new System.Drawing.Size(630, 26);
            this.tlp_labelrow.TabIndex = 0;
            // 
            // btn_CategorySort
            // 
            this.btn_CategorySort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
            this.btn_CategorySort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CategorySort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CategorySort.Location = new System.Drawing.Point(601, 1);
            this.btn_CategorySort.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CategorySort.Name = "btn_CategorySort";
            this.btn_CategorySort.Size = new System.Drawing.Size(28, 24);
            this.btn_CategorySort.TabIndex = 7;
            this.btn_CategorySort.TabStop = false;
            this.btn_CategorySort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CategorySort.UseVisualStyleBackColor = false;
            this.btn_CategorySort.Click += new System.EventHandler(this.btn_CategorySort_Click);
            // 
            // btn_AmountSort
            // 
            this.btn_AmountSort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
            this.btn_AmountSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AmountSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AmountSort.Location = new System.Drawing.Point(494, 1);
            this.btn_AmountSort.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AmountSort.Name = "btn_AmountSort";
            this.btn_AmountSort.Size = new System.Drawing.Size(20, 24);
            this.btn_AmountSort.TabIndex = 6;
            this.btn_AmountSort.TabStop = false;
            this.btn_AmountSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AmountSort.UseVisualStyleBackColor = false;
            this.btn_AmountSort.Click += new System.EventHandler(this.btn_AmountSort_Click);
            // 
            // btn_DescriptionSort
            // 
            this.btn_DescriptionSort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
            this.btn_DescriptionSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DescriptionSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DescriptionSort.Location = new System.Drawing.Point(387, 1);
            this.btn_DescriptionSort.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DescriptionSort.Name = "btn_DescriptionSort";
            this.btn_DescriptionSort.Size = new System.Drawing.Size(20, 24);
            this.btn_DescriptionSort.TabIndex = 5;
            this.btn_DescriptionSort.TabStop = false;
            this.btn_DescriptionSort.Text = "-";
            this.btn_DescriptionSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DescriptionSort.UseVisualStyleBackColor = false;
            this.btn_DescriptionSort.Click += new System.EventHandler(this.btn_DescriptionSort_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(518, 1);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(79, 24);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(411, 1);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(79, 24);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(111, 1);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(272, 24);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(4, 1);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(79, 24);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DateSort
            // 
            this.btn_DateSort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
            this.btn_DateSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DateSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DateSort.Location = new System.Drawing.Point(87, 1);
            this.btn_DateSort.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DateSort.Name = "btn_DateSort";
            this.btn_DateSort.Size = new System.Drawing.Size(20, 24);
            this.btn_DateSort.TabIndex = 4;
            this.btn_DateSort.TabStop = false;
            this.btn_DateSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DateSort.UseVisualStyleBackColor = false;
            this.btn_DateSort.Click += new System.EventHandler(this.btn_DateSort_Click);
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
            this.tlp_ButtonRow.Location = new System.Drawing.Point(5, 448);
            this.tlp_ButtonRow.Name = "tlp_ButtonRow";
            this.tlp_ButtonRow.RowCount = 1;
            this.tlp_ButtonRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ButtonRow.Size = new System.Drawing.Size(630, 27);
            this.tlp_ButtonRow.TabIndex = 1;
            // 
            // btn_removeRow
            // 
            this.btn_removeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_removeRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeRow.Location = new System.Drawing.Point(585, 3);
            this.btn_removeRow.Name = "btn_removeRow";
            this.btn_removeRow.Size = new System.Drawing.Size(18, 21);
            this.btn_removeRow.TabIndex = 0;
            this.btn_removeRow.Text = "-";
            this.btn_removeRow.UseVisualStyleBackColor = true;
            this.btn_removeRow.Click += new System.EventHandler(this.btn_removeRow_Click);
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRow.Location = new System.Drawing.Point(609, 3);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(18, 21);
            this.btn_AddRow.TabIndex = 1;
            this.btn_AddRow.Text = "+";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // tlp_ItemRows
            // 
            this.tlp_ItemRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_ItemRows.AutoScroll = true;
            this.tlp_ItemRows.ColumnCount = 2;
            this.tlp_ItemRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ItemRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_ItemRows.Location = new System.Drawing.Point(2, 200);
            this.tlp_ItemRows.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ItemRows.Name = "tlp_ItemRows";
            this.tlp_ItemRows.RowCount = 1;
            this.tlp_ItemRows.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ItemRows.Size = new System.Drawing.Size(636, 243);
            this.tlp_ItemRows.TabIndex = 2;
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
        private System.Windows.Forms.TableLayoutPanel tlp_ItemRows;
        private System.Windows.Forms.Button btn_CategorySort;
        private System.Windows.Forms.Button btn_AmountSort;
        private System.Windows.Forms.Button btn_DescriptionSort;
        private System.Windows.Forms.Button btn_DateSort;
    }
}
