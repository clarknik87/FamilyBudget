﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    public partial class Month_summary : UserControl
    {
        TableLayoutPanel summary_rows = null;
        bool isExpense;
        Month_tab parentMonthTab = null;

        Dictionary<String, int> summary_data;

        public Month_summary()
        {
            InitializeComponent();
        }

        public void SetupRows(bool isExpenseTab, Month_tab p_mt)
        {
            isExpense = isExpenseTab;
            parentMonthTab = p_mt;
            summary_data = new Dictionary<string, int>();
            summary_rows = new TableLayoutPanel();

            //setup all of the rows
            summary_rows.ColumnCount = 4;
            summary_rows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            summary_rows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            summary_rows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            summary_rows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            summary_rows.Dock = DockStyle.Fill;
            summary_rows.AutoScroll = true;

            List<String> categories;

            if (isExpense)
            {
                categories = Global.ExpenseCategories;
            }
            else
            {
                categories = Global.IncomeCategories;
            }

            summary_rows.RowCount = categories.Count();

            int rw = 0;
            foreach (String c in categories)
            {
                // create the category label
                Label lb_cat = new Label();
                lb_cat.Dock = DockStyle.Fill;
                lb_cat.Text = c;
                summary_rows.Controls.Add(lb_cat, 0, rw);

                // create the planned textbox
                TextBox tb_plan = new TextBox();
                tb_plan.Dock = DockStyle.Fill;
                tb_plan.Text = "$0.00";
                summary_rows.Controls.Add(tb_plan, 1, rw);

                // created the actual label
                Label lb_act = new Label();
                lb_act.Dock = DockStyle.Fill;
                lb_act.Text = "$0.00";
                summary_rows.Controls.Add(lb_act, 2, rw);

                // create the difference box
                Label lb_diff = new Label();
                lb_diff.Dock = DockStyle.Fill;
                lb_diff.Text = "$0.00";
                summary_rows.Controls.Add(lb_diff, 3, rw);

                // create the data
                summary_data.Add(c,0);

                //increment row counter
                ++rw;
            }

            tlp_toplevel.Controls.Add(summary_rows, 0, 1);
        }

        private void lb_Plan_Click(object sender, EventArgs e)
        {

        }
    }
}