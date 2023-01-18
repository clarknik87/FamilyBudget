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

        public List<String> Categories { get; set; }

        public String GetDate()
        {
            return tb_DateCell.Text;
        }

        public String GetDescription()
        {
            return tb_DescriptionCell.Text;
        }

        public int GetAmount()
        {
            String amount = tb_AmountCell.Text;
            amount = amount.Substring(1);
            return int.Parse(amount);
        }

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

        private void tb_AmountCell_Leave(object sender, EventArgs e)
        {
            TextBox amount_cell = sender as TextBox;
            String amount_raw = amount_cell.Text;
            String amount_formatted = "";

            if (Regex.IsMatch(amount_raw, @"^\$?\d+$") || Regex.IsMatch(amount_raw, @"^\$?\d+\.\d+$") || Regex.IsMatch(amount_raw, @"^\$?\.\d+$"))
            {
                //Raw text is valid
                if (Regex.IsMatch(amount_raw, @"\."))
                {
                    String amount_dollar = Regex.Split(amount_raw, @"\.")[0];
                    if(amount_dollar[0] == '$')
                    {
                        amount_dollar = Regex.Split(amount_dollar, @"\$")[1];
                    }
                    String amount_cents = Regex.Split(amount_raw, @"\.")[1];

                    amount_formatted += "$" + amount_dollar + "." + amount_cents;
                    amount_cell.Text = amount_formatted;

                    return;
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
                    amount_cell.Text = amount_formatted;
                    return;
                }
            }

            //Raw text is invalid
            amount_formatted = "$00.00";
            amount_cell.Text = amount_formatted;
            return;
        }

        private void tb_DateCell_Leave(object sender, EventArgs e)
        {
            TextBox datecell = sender as TextBox;
            String date_raw = datecell.Text;
            String date_formatted = "";
            String month_name = datecell.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Text;
            int month_digits = Global.Months.IndexOf(month_name) + 1;

            if (Regex.IsMatch(date_raw, @"./.")) //Day and Month Entered
            {
                String date_day = Regex.Split(date_raw, @"/")[1];
                String date_month = Regex.Split(date_raw, @"/")[0];

                //Deal with the month portion
                if(Regex.IsMatch(date_month, @"^\d$"))
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
                    datecell.Text = date_formatted;
                    return;
                }
            }
            else if(Regex.IsMatch(date_raw, @"^\d{1,2}$")) //Only Day entered
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
                else if(Regex.IsMatch(date_raw, @"^\d\d$"))
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

                datecell.Text = date_formatted;
                return;
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
            datecell.Text = date_formatted;
        }
    }
}
