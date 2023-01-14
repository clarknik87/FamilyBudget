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
    public partial class Month_tab : UserControl
    {
        public void AddBlankRow()
        {
            if (!InvokeRequired)
            {
                Row_item tmp = new Row_item();
                tmp.Dock = DockStyle.Top;
                tlp_ItemRows.RowCount += 1;
                tlp_ItemRows.Controls.Add(tmp, 0, tlp_ItemRows.RowCount);
            }
            else
            {
                Invoke(new MethodInvoker(() => { AddBlankRow(); }));
            }
        }

        public void RemoveFinalRow()
        {
            if (!InvokeRequired)
            {
                Row_item last_row = null;
                foreach(Row_item i in tlp_ItemRows.Controls)
                {
                    last_row = i;
                }
                if (last_row != null)
                {
                    tlp_ItemRows.Controls.Remove(last_row);
                }
            }
            else
            {
                Invoke(new MethodInvoker(() => { RemoveFinalRow(); }));
            }
        }

        public Month_tab()
        {
            InitializeComponent();
            tlp_ItemRows.AutoScroll = false;
            tlp_ItemRows.HorizontalScroll.Enabled = false;
            tlp_ItemRows.AutoScroll = true;
        }

        private void btn_removeRow_Click(object sender, EventArgs e)
        {
            RemoveFinalRow();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            AddBlankRow();
        }
    }
}
