using System;
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
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();

            List<string> months = new List<string>{ 
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            foreach(string m in months)
            {
                //Create two month tab controls
                Month_tab expense_ctl = new Month_tab();
                Month_tab income_ctl = new Month_tab();

                expense_ctl.Dock = DockStyle.Fill;
                income_ctl.Dock = DockStyle.Fill;

                //Create expense and income tabs
                System.Windows.Forms.TabPage expense_tab = new System.Windows.Forms.TabPage("Expenses");
                System.Windows.Forms.TabPage income_tab = new System.Windows.Forms.TabPage("Income");

                //Add month tabs
                expense_tab.Controls.Add(expense_ctl);
                income_tab.Controls.Add(income_ctl);

                //Create a tab controller for each month and add expense and income tabs
                System.Windows.Forms.TabControl tctl = new System.Windows.Forms.TabControl();
                tctl.Dock = DockStyle.Fill;
                tctl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
                tctl.TabPages.Add(expense_tab);
                tctl.TabPages.Add(income_tab);

                System.Windows.Forms.TabPage tp = new System.Windows.Forms.TabPage(m);

                tp.Controls.Add(tctl);

                tc_TabController.TabPages.Add(tp);
            }
        }
    }
}
