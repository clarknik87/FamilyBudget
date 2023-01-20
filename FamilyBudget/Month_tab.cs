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

                if(isExpenseTab)
                {
                    tmp.Categories = Global.ExpenseCategories;
                    foreach (var cat in Global.ExpenseCategories)
                    {
                        tmp.lb_CategoryCell.Items.Add(cat);
                    }
                }
                else
                {
                    tmp.Categories = Global.IncomeCategories;
                    foreach (var cat in Global.IncomeCategories)
                    {
                        tmp.lb_CategoryCell.Items.Add(cat);
                    }
                }

                if (tlp_ItemRows.RowCount % 2 == 0)
                {
                    Color cellColor;
                    if(isExpenseTab)
                    {
                        cellColor = ColorTranslator.FromHtml("#a5d3e8");
                    }
                    else //income tab
                    {
                        cellColor = ColorTranslator.FromHtml("#a9eb9d");
                    }
                    tmp.tb_DateCell.BackColor = cellColor;
                    tmp.tb_DescriptionCell.BackColor = cellColor;
                    tmp.tb_AmountCell.BackColor = cellColor;
                    tmp.lb_CategoryCell.BackColor = cellColor;

                }
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

        public bool isExpenseTab { get; set; }

        public Month_tab()
        {
            InitializeComponent();
            tlp_ItemRows.AutoScroll = false;
            tlp_ItemRows.HorizontalScroll.Enabled = false;
            tlp_ItemRows.AutoScroll = true;

            //btn_DateSort.Image.Size = btn_DateSort.Size;
        }

        private void btn_removeRow_Click(object sender, EventArgs e)
        {
            RemoveFinalRow();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            AddBlankRow();
        }

        //Sort functions
        public enum Sort_Option
        {
            Date,
            Description,
            Amount,
            Category
        }

        public Int32 CompareDate(Row_item a, Row_item b)
        {
            return String.Compare(a.GetDate(), b.GetDate());
        }

        public Int32 CompareDescription(Row_item a, Row_item b)
        {
            return String.Compare(a.GetDescription(), b.GetDescription());
        }

        public Int32 CompareAmount(Row_item a, Row_item b)
        {
            if(a.GetAmount() > b.GetAmount())
            {
                return 1;
            }
            else if(a.GetAmount() == b.GetAmount())
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public Int32 CompareCategory(Row_item a, Row_item b)
        {
            return String.Compare(a.GetCategory(), b.GetCategory());
        }

        public void Sort_Rows(Sort_Option opt)
        {
            if (!InvokeRequired)
            {
                SuspendLayout();
                List<Row_item> rws = new List<Row_item>();
                foreach (var e in tlp_ItemRows.Controls)
                {
                    rws.Add(e as Row_item);
                }

                tlp_ItemRows.Controls.Clear();

                switch (opt)
                {
                    case Sort_Option.Date:
                        rws.Sort(CompareDate);
                        break;
                    case Sort_Option.Description:
                        rws.Sort(CompareDescription);
                        break;
                    case Sort_Option.Amount:
                        rws.Sort(CompareAmount);
                        break;
                    case Sort_Option.Category:
                        rws.Sort(CompareCategory);
                        break;
                }

                int row_counter = 0;
                foreach(var e in rws)
                {
                    Color cellColor;
                    if (row_counter % 2 == 0)
                    {
                        if (isExpenseTab)
                        {
                            cellColor = ColorTranslator.FromHtml("#a5d3e8");
                        }
                        else //income tab
                        {
                            cellColor = ColorTranslator.FromHtml("#a9eb9d");
                        }
                    }
                    else
                    {
                        cellColor = SystemColors.Control;
                    }

                    e.tb_DateCell.BackColor = cellColor;
                    e.tb_DescriptionCell.BackColor = cellColor;
                    e.tb_AmountCell.BackColor = cellColor;
                    e.lb_CategoryCell.BackColor = cellColor;

                    tlp_ItemRows.Controls.Add(e);
                    tlp_ItemRows.SetRow(e, row_counter);
                    ++row_counter;
                }
                ResumeLayout();
            }
            else
            {
                Invoke(new MethodInvoker(() => { Sort_Rows(opt); }));
            }
        }

        //Sort Buttons
        private void btn_DateSort_Click(object sender, EventArgs e)
        {
            if(tlp_ItemRows.Controls.Count > 0)
            {
                Sort_Rows(Sort_Option.Date);
            }
        }

        private void btn_AmountSort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                Sort_Rows(Sort_Option.Amount);
            };
        }

        private void btn_DescriptionSort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                Sort_Rows(Sort_Option.Description);
            };
        }

        private void btn_CategorySort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                Sort_Rows(Sort_Option.Category);
            };
        }
    }
}
