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
    public partial class TopSummary : UserControl
    {
        public TopSummary()
        {
            InitializeComponent();
        }

        const int ColumnsCharacterWidth = 12;
        //Dictionary<String,Label> summary_row_labels;

        private String PadNumberField(double d)
        {
            String s = "$" + d.ToString("N2");
            while(s.Count() < ColumnsCharacterWidth)
            {
                s += " ";
            }
            return s;
        }

        private String PadText(String s)
        {
            while (s.Count() < ColumnsCharacterWidth)
            {
                s += " ";
            }
            return s;
        }

        public void SetupSummaryTable()
        {
            SuspendLayout();
            this.Visible = false;

            tlp_summarytable.AutoScroll = true;

            tlp_summarytable.RowCount = Global.Months.Count() + 4;
            tlp_summarytable.ColumnCount = 1;
            int row_idx = 0;

            //setup top row
            Label lb_top = new Label();
            String top_text = PadText("") + PadText("Income");
            for(int i=0; i<Global.IncomeCategories.Count; ++i)
            {
                top_text += PadText("") + PadText("");
            }
            top_text += PadText("") + PadText("Expenses");
            foreach (String s in Global.ExpenseCategories)
            {
                top_text += PadText("") + PadText("");
            }
            lb_top.Text = top_text;
            lb_top.Font = new Font("Source Code Pro", lb_top.Font.Size);
            lb_top.Dock = DockStyle.Fill;
            tlp_summarytable.Controls.Add(lb_top,0, row_idx);
            ++row_idx;

            //setup category row
            Label lb_cat = new Label();
            String cat_text = PadText("");
            foreach (String s in Global.IncomeCategories)
            {
                cat_text += PadText(s) + PadText("");
            }

            foreach (String s in Global.ExpenseCategories)
            {
                cat_text += PadText(s) + PadText("");
            }
            lb_cat.Text = cat_text;
            lb_cat.Font = new Font("Source Code Pro", lb_cat.Font.Size);
            lb_cat.Dock = DockStyle.Fill;
            tlp_summarytable.Controls.Add(lb_cat, 0, row_idx);
            ++row_idx;

            //setup header rows
            Label lb_hd1 = new Label();
            String hdr_text = PadText("");
            foreach (String s in Global.IncomeCategories)
            {
                hdr_text += PadText("plan") + PadText("actual");
            }

            foreach (String s in Global.ExpenseCategories)
            {
                hdr_text += PadText("plan") + PadText("actual"); ;
            }
            lb_hd1.Text = hdr_text;
            lb_hd1.Font = new Font("Source Code Pro", lb_hd1.Font.Size);
            lb_hd1.Dock = DockStyle.Fill;
            tlp_summarytable.Controls.Add(lb_hd1, 0, row_idx);
            ++row_idx;

            //setup month rows
            String row_text = String.Empty;
            foreach (String m in Global.Months)
            {
                Label lb_m = new Label();
                row_text = PadText(m);

                foreach(String s in Global.IncomeCategories)
                {
                    row_text += PadNumberField(0.0) + PadNumberField(0.0);
                }

                foreach(String s in Global.ExpenseCategories)
                {
                    row_text += PadNumberField(0.0) + PadNumberField(0.0);
                }

                lb_m.Text = row_text;
                lb_m.Font = new Font("Source Code Pro", lb_m.Font.Size);
                lb_m.Dock = DockStyle.Fill;
                tlp_summarytable.Controls.Add(lb_m, 0, row_idx);
                ++row_idx;
            }

            //setup total row
            Label lb_t = new Label();
            String total_text = PadText("Total");

            foreach (String s in Global.IncomeCategories)
            {
                total_text += PadNumberField(0.0) + PadNumberField(0.0);
            }

            foreach (String s in Global.ExpenseCategories)
            {
                total_text += PadNumberField(0.0) + PadNumberField(0.0);
            }

            lb_t.Text = total_text;
            lb_t.Font = new Font("Source Code Pro", lb_t.Font.Size);
            lb_t.Dock = DockStyle.Fill;
            tlp_summarytable.Controls.Add(lb_t, 0, row_idx);
            ++row_idx;

            List<Label> lbl_lst = new List<Label>();
            lbl_lst.Add(lb_hd1);
            lbl_lst.Add(lb_cat);
            lbl_lst.Add(lb_t);
            lbl_lst.Sort((x,y) => (y.Text.Length.CompareTo(x.Text.Length)));
            tlp_summarytable.ColumnStyles[0].SizeType = SizeType.Absolute;
            tlp_summarytable.ColumnStyles[0].Width = TextRenderer.MeasureText(lbl_lst[0].Text,lbl_lst[0].Font).Width;

            this.Visible = true;
            ResumeLayout();
        }
    }
}
