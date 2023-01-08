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
                Month_tab mt = new Month_tab();
                mt.Dock = DockStyle.Fill;

                System.Windows.Forms.TabPage tp = new System.Windows.Forms.TabPage(m);
                tp.Controls.Add(mt);

                tc_TabController.TabPages.Add(tp);
            }
        }
    }
}
