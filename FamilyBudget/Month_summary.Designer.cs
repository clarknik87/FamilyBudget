
namespace FamilyBudget
{
    partial class Month_summary
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
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Actual = new System.Windows.Forms.Label();
            this.lb_Plan = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.tlp_toplevel = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Difference = new System.Windows.Forms.Label();
            this.tlp_header.SuspendLayout();
            this.tlp_toplevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_header
            // 
            this.tlp_header.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_header.ColumnCount = 4;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_header.Controls.Add(this.lb_Actual, 2, 0);
            this.tlp_header.Controls.Add(this.lb_Plan, 1, 0);
            this.tlp_header.Controls.Add(this.lb_category, 0, 0);
            this.tlp_header.Controls.Add(this.lb_Difference, 3, 0);
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_header.Location = new System.Drawing.Point(3, 3);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_header.Size = new System.Drawing.Size(314, 26);
            this.tlp_header.TabIndex = 0;
            // 
            // lb_Actual
            // 
            this.lb_Actual.AutoSize = true;
            this.lb_Actual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Actual.Location = new System.Drawing.Point(160, 1);
            this.lb_Actual.Name = "lb_Actual";
            this.lb_Actual.Size = new System.Drawing.Size(71, 36);
            this.lb_Actual.TabIndex = 2;
            this.lb_Actual.Text = "Actual";
            this.lb_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Plan
            // 
            this.lb_Plan.AutoSize = true;
            this.lb_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Plan.Location = new System.Drawing.Point(82, 1);
            this.lb_Plan.Name = "lb_Plan";
            this.lb_Plan.Size = new System.Drawing.Size(71, 36);
            this.lb_Plan.TabIndex = 1;
            this.lb_Plan.Text = "Planned";
            this.lb_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Plan.Click += new System.EventHandler(this.lb_Plan_Click);
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.Location = new System.Drawing.Point(4, 1);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(71, 36);
            this.lb_category.TabIndex = 0;
            this.lb_category.Text = "Category";
            this.lb_category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlp_toplevel
            // 
            this.tlp_toplevel.ColumnCount = 1;
            this.tlp_toplevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_toplevel.Controls.Add(this.tlp_header, 0, 0);
            this.tlp_toplevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_toplevel.Location = new System.Drawing.Point(0, 0);
            this.tlp_toplevel.Name = "tlp_toplevel";
            this.tlp_toplevel.RowCount = 2;
            this.tlp_toplevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_toplevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_toplevel.Size = new System.Drawing.Size(320, 160);
            this.tlp_toplevel.TabIndex = 1;
            // 
            // lb_Difference
            // 
            this.lb_Difference.AutoSize = true;
            this.lb_Difference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Difference.Location = new System.Drawing.Point(238, 1);
            this.lb_Difference.Name = "lb_Difference";
            this.lb_Difference.Size = new System.Drawing.Size(72, 36);
            this.lb_Difference.TabIndex = 3;
            this.lb_Difference.Text = "Difference";
            this.lb_Difference.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Month_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_toplevel);
            this.Name = "Month_summary";
            this.Size = new System.Drawing.Size(320, 160);
            this.tlp_header.ResumeLayout(false);
            this.tlp_header.PerformLayout();
            this.tlp_toplevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.Label lb_Actual;
        private System.Windows.Forms.Label lb_Plan;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.TableLayoutPanel tlp_toplevel;
        private System.Windows.Forms.Label lb_Difference;
    }
}
