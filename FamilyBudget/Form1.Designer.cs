namespace FamilyBudget
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_TabController = new System.Windows.Forms.TabControl();
            this.Summary = new System.Windows.Forms.TabPage();
            this.tc_TabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_TabController
            // 
            this.tc_TabController.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc_TabController.Controls.Add(this.Summary);
            this.tc_TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_TabController.Location = new System.Drawing.Point(0, 0);
            this.tc_TabController.Name = "tc_TabController";
            this.tc_TabController.SelectedIndex = 0;
            this.tc_TabController.Size = new System.Drawing.Size(800, 450);
            this.tc_TabController.TabIndex = 0;
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(4, 4);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3);
            this.Summary.Size = new System.Drawing.Size(792, 424);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_TabController);
            this.Name = "MainForm";
            this.Text = "Family Budget";
            this.tc_TabController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_TabController;
        private System.Windows.Forms.TabPage Summary;
    }
}

