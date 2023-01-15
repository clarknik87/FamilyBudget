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
    public partial class Row_item : UserControl
    {
        public Row_item()
        {
            InitializeComponent();
        }

        public List<String> Categories { get; set; }

        private void lb_CategoryCell_Leave(object sender, EventArgs e)
        {
            //Verify that the text entered is one of the categories. If not set to other
            ComboBox rwitem = sender as ComboBox;
            if(!Categories.Contains(rwitem.Text))
            {
                if (Categories.Count > 0)
                {
                    rwitem.Text = Categories[0];
                }
                else
                {
                    rwitem.Text = "";
                }
            }
        }
    }
}
