using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FamilyBudget
{
    public partial class Row_item : UserControl
    {
        public Row_item()
        {
            InitializeComponent();
        }

        public Month_tab parentMonthTab { get; set; } = null;

        public List<String> Categories { get; set; }

        public String GetDate()
        {
            return tb_DateCell.Text;
        }

        static String ValidateDateText(String date_raw, String month_name)
        {
            String date_formatted = "";
            int month_digits = Global.Months.IndexOf(month_name) + 1;

            if (Regex.IsMatch(date_raw, @"./.")) //Day and Month Entered
            {
                String date_day = Regex.Split(date_raw, @"/")[1];
                String date_month = Regex.Split(date_raw, @"/")[0];

                //Deal with the month portion
                if (Regex.IsMatch(date_month, @"^\d$"))
                {
                    date_formatted += "0" + date_month;
                }
                else if (Regex.IsMatch(date_month, @"^\d\d$"))
                {
                    if (Int32.Parse(date_month) > 0 && Int32.Parse(date_month) <= 12)
                    {
                        date_formatted += date_month;
                    }
                    else
                    {
                        date_formatted += month_digits;
                    }
                }

                //Deal with the day portion
                if (Regex.IsMatch(date_day, @"^\d$")) //one digit
                {
                    date_formatted += "/";
                    date_formatted += "0" + date_day;
                }
                else if (Regex.IsMatch(date_day, @"^\d\d$"))
                {
                    date_formatted += "/";
                    if (Int32.Parse(date_day) < 31)
                    {
                        date_formatted += date_day;
                    }
                    else
                    {
                        date_formatted += "31";
                    }
                }

                if (Regex.IsMatch(date_formatted, @"\d\d/\d\d"))
                {
                    return date_formatted;
                }
            }
            else if (Regex.IsMatch(date_raw, @"^\d{1,2}$")) //Only Day entered
            {
                // Deal with the month part
                if (month_digits < 10)
                {
                    date_formatted += "0" + month_digits.ToString() + "/";
                }
                else
                {
                    date_formatted += month_digits.ToString() + "/";
                }

                // Deal with the day part
                if (Regex.IsMatch(date_raw, @"^\d$"))
                {
                    date_formatted += "0" + date_raw;
                }
                else if (Regex.IsMatch(date_raw, @"^\d\d$"))
                {
                    if (Int32.Parse(date_raw) < 31)
                    {
                        date_formatted += date_raw;
                    }
                    else
                    {
                        date_formatted += "31";
                    }
                }

                return date_formatted;
            }

            //The date was invalid
            if (month_digits < 10)
            {
                date_formatted = "0" + month_digits.ToString() + "/00";
            }
            else
            {
                date_formatted = month_digits.ToString() + "/00";
            }
            return date_formatted;
        }

        public void SetDate(String p_date, String month)
        {
            tb_DateCell.Text = ValidateDateText(p_date, month);
        }

        public String GetDescription()
        {
            return tb_DescriptionCell.Text;
        }

        public void SetDescription(String p_text)
        {
            tb_DescriptionCell.Text = p_text;
        }

        public double GetAmount()
        {
            String amount = tb_AmountCell.Text;
            if (amount != "")
            {
                amount = amount.Substring(1);
                return double.Parse(amount);
            }
            return 0.0;
        }

        static String ValidateAmountText(String amount_raw)
        {
            String amount_formatted = "";

            if (Regex.IsMatch(amount_raw, @"^\$?\d+$") || Regex.IsMatch(amount_raw, @"^\$?\d+\.\d+$") || Regex.IsMatch(amount_raw, @"^\$?\.\d+$"))
            {
                //Raw text is valid
                if (Regex.IsMatch(amount_raw, @"\."))
                {
                    String amount_dollar = Regex.Split(amount_raw, @"\.")[0];
                    if (amount_dollar[0] == '$')
                    {
                        amount_dollar = Regex.Split(amount_dollar, @"\$")[1];
                    }
                    String amount_cents = Regex.Split(amount_raw, @"\.")[1];

                    amount_formatted += "$" + amount_dollar + "." + amount_cents;
                    return amount_formatted;
                }
                else if (Regex.IsMatch(amount_raw, @"^\$?\d+$"))
                {
                    //Raw text is formatted as either $x or x
                    String amount_dollar = amount_raw;
                    if (amount_dollar[0] == '$')
                    {
                        amount_dollar = Regex.Split(amount_dollar, @"\$")[1];
                    }

                    amount_formatted += "$" + amount_dollar + ".00";
                    return amount_formatted;
                }
            }

            //Raw text is invalid
            amount_formatted = "$00.00";
            return amount_formatted;
        }

        public void SetAmount(String amount_raw)
        {
            tb_AmountCell.Text = ValidateAmountText(amount_raw);
        }

        public String GetCategory()
        {
            return lb_CategoryCell.Text;
        }

        static String ValidateCategoryText(String cat_raw, List<String> p_categories)
        {
            if (!p_categories.Contains(cat_raw))
            {
                if (p_categories.Count > 0)
                {
                    return p_categories[0];
                }
                else
                {
                    return String.Empty;
                }
            }

            return cat_raw;
        }

        public void SetCategory(String p_cat)
        {
            lb_CategoryCell.Text = ValidateCategoryText(p_cat, Categories);
        }

        private void lb_CategoryCell_Leave(object sender, EventArgs e)
        {
            MainForm.FileEdited = true;
            ComboBox rwitem = sender as ComboBox;
            SetCategory(rwitem.Text);
            parentMonthTab.UpdateSummarySection();
        }

        private void tb_AmountCell_Leave(object sender, EventArgs e)
        {
            MainForm.FileEdited = true;
            TextBox amount_cell = sender as TextBox;
            SetAmount(amount_cell.Text);
            parentMonthTab.UpdateSummarySection();
        }

        private void tb_DateCell_Leave(object sender, EventArgs e)
        {
            MainForm.FileEdited = true;
            TextBox datecell = sender as TextBox;
            String month_name = (datecell.Parent.Parent.Parent.Parent.Parent as Month_tab).month;
            SetDate(datecell.Text, month_name);
        }

        private void tb_DescriptionCell_Leave(object sender, EventArgs e)
        {
            MainForm.FileEdited = true;
        }
    }
}
