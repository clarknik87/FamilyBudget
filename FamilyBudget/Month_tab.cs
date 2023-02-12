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
        public void AddRow(String p_date, String p_descr, String p_amt, String p_cat)
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

                if (p_date != String.Empty)     { tmp.SetDate(p_date, month); }
                if (p_descr != String.Empty)    { tmp.SetDescription(p_descr); }
                if (p_amt != String.Empty)      { tmp.SetAmount(p_amt); }
                if (p_cat != String.Empty)      { tmp.SetCategory(p_cat); }


                tlp_ItemRows.Controls.Add(tmp, 0, tlp_ItemRows.RowCount);
            }
            else
            {
                Invoke(new MethodInvoker(() => { AddRow(p_date, p_descr, p_amt, p_cat ); }));
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

        public List<Row_item> GetRows()
        {
            List<Row_item> rwitems = new List<Row_item>();
            foreach(var i in tlp_ItemRows.Controls)
            {
                rwitems.Add(i as Row_item);
            }
            return rwitems;
        }

        public bool isExpenseTab { get; set; }
        public String month { get; set; }

        public Month_tab()
        {
            InitializeComponent();
            tlp_ItemRows.AutoScroll = false;
            tlp_ItemRows.HorizontalScroll.Enabled = false;
            tlp_ItemRows.AutoScroll = true;
        }

        public void SetupSummarySection()
        {
            this.month_summary_table.SetupRows(isExpenseTab, this);
        }

        private void btn_removeRow_Click(object sender, EventArgs e)
        {
            RemoveFinalRow();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            AddRow(String.Empty, String.Empty, String.Empty, String.Empty);
        }

        //Sort functions
        public enum Sort_Option
        {
            Date,
            Description,
            Amount,
            Category
        }

        public enum Sort_State
        {
            None,
            Up,
            Down
        }

        public Sort_State btnDateState { get; set; } = Sort_State.None;
        public Sort_State btnDescriptionState { get; set; } = Sort_State.None;
        public Sort_State btnAmountState { get; set; } = Sort_State.None;
        public Sort_State btnCategoryState { get; set; } = Sort_State.None;


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

        public void Sort_Rows(Sort_Option opt, bool reverse)
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

                if(reverse)
                {
                    rws.Reverse();
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

                    e.lb_CategoryCell.SelectionLength = 0;

                    tlp_ItemRows.Controls.Add(e);
                    tlp_ItemRows.SetRow(e, row_counter);
                    ++row_counter;
                }
                ResumeLayout();

                //Keep the first category in the list from being selected. idk why this is needed...
                (tlp_ItemRows.Controls[0] as Row_item).lb_CategoryCell.SelectionLength = 0;
            }
            else
            {
                Invoke(new MethodInvoker(() => { Sort_Rows(opt, reverse); }));
            }
        }

        //Sort Buttons
        private void btn_DateSort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                //Reset other buttons
                btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDescriptionState = Sort_State.None;
                btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnAmountState = Sort_State.None;
                btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnCategoryState = Sort_State.None;

                //Step to next button state and sort
                if (btnDateState == Sort_State.None || btnDateState == Sort_State.Up)
                {
                    btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_down;
                    btnDateState = Sort_State.Down;
                    Sort_Rows(Sort_Option.Date, false);
                }
                else
                {
                    btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_up;
                    btnDateState = Sort_State.Up;
                    Sort_Rows(Sort_Option.Date, true);
                }
            }
        }

        private void btn_AmountSort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                //Reset other buttons
                btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDateState = Sort_State.None;
                btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDescriptionState = Sort_State.None;
                btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnCategoryState = Sort_State.None;

                //Step to next button state and sort
                if (btnAmountState == Sort_State.None || btnAmountState == Sort_State.Up)
                {
                    btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_down;
                    btnAmountState = Sort_State.Down;
                    Sort_Rows(Sort_Option.Amount, false);
                }
                else
                {
                    btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_up;
                    btnAmountState = Sort_State.Up;
                    Sort_Rows(Sort_Option.Amount, true);
                }
            }
        }

        private void btn_DescriptionSort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                //Reset other buttons
                btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDateState = Sort_State.None;
                //btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                //btnDescriptionState = Sort_State.None;
                btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnAmountState = Sort_State.None;
                btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnCategoryState = Sort_State.None;

                //Step to next button state and sort
                if (btnDescriptionState == Sort_State.None || btnDescriptionState == Sort_State.Up)
                {
                    btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_down;
                    btnDescriptionState = Sort_State.Down;
                    Sort_Rows(Sort_Option.Description, false);
                }
                else
                {
                    btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_up;
                    btnDescriptionState = Sort_State.Up;
                    Sort_Rows(Sort_Option.Description, true);
                }
            }
        }

        private void btn_CategorySort_Click(object sender, EventArgs e)
        {
            if (tlp_ItemRows.Controls.Count > 0)
            {
                //Reset other buttons
                btn_DateSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDateState = Sort_State.None;
                btn_DescriptionSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnDescriptionState = Sort_State.None;
                btn_AmountSort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                btnAmountState = Sort_State.None;
                //btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_none;
                //btnCategoryState = Sort_State.None;

                //Step to next button state and sort
                if (btnCategoryState == Sort_State.None || btnCategoryState == Sort_State.Up)
                {
                    btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_down;
                    btnCategoryState = Sort_State.Down;
                    Sort_Rows(Sort_Option.Category, false);
                }
                else
                {
                    btn_CategorySort.BackgroundImage = global::FamilyBudget.Properties.Resources.sort_up;
                    btnCategoryState = Sort_State.Up;
                    Sort_Rows(Sort_Option.Category, true);
                }
            }
        }
    }
}
