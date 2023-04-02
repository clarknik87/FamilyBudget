
namespace FamilyBudget
{
    partial class TopSummary
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
            this.tlp_toplevel = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_summarytable = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_toplevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_toplevel
            // 
            this.tlp_toplevel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlp_toplevel.ColumnCount = 1;
            this.tlp_toplevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_toplevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_toplevel.Controls.Add(this.tlp_summarytable, 0, 1);
            this.tlp_toplevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_toplevel.Location = new System.Drawing.Point(0, 0);
            this.tlp_toplevel.Name = "tlp_toplevel";
            this.tlp_toplevel.RowCount = 2;
            this.tlp_toplevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_toplevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_toplevel.Size = new System.Drawing.Size(640, 480);
            this.tlp_toplevel.TabIndex = 0;
            // 
            // tlp_summarytable
            // 
            this.tlp_summarytable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_summarytable.AutoSize = true;
            this.tlp_summarytable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_summarytable.ColumnCount = 1;
            this.tlp_summarytable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tlp_summarytable.Location = new System.Drawing.Point(5, 244);
            this.tlp_summarytable.Name = "tlp_summarytable";
            this.tlp_summarytable.RowCount = 1;
            this.tlp_summarytable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_summarytable.Size = new System.Drawing.Size(630, 231);
            this.tlp_summarytable.TabIndex = 0;
            // 
            // TopSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_toplevel);
            this.Name = "TopSummary";
            this.Size = new System.Drawing.Size(640, 480);
            this.tlp_toplevel.ResumeLayout(false);
            this.tlp_toplevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_toplevel;
        private System.Windows.Forms.TableLayoutPanel tlp_summarytable;
    }
}
