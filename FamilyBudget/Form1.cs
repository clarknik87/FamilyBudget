using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FamilyBudget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MainMenu mainMenu = new MainMenu();
            MenuItem File = mainMenu.MenuItems.Add("&File");
            File.MenuItems.Add(new MenuItem("&Open", new EventHandler(open_Clicked)));
            File.MenuItems.Add(new MenuItem("&Save", new EventHandler(save_Clicked)));
            File.MenuItems.Add(new MenuItem("&Exit", new EventHandler(exit_Clicked)));
            this.Menu = mainMenu;
        }

        private void setupTabs(Dictionary<String, List<String>> fileContent, Dictionary<String, List<String>> summaryContent)
        {
            foreach (string m in Global.Months)
            {
                //Create two month tab controls
                Month_tab expense_ctl = new Month_tab();
                Month_tab income_ctl = new Month_tab();

                expense_ctl.Dock = DockStyle.Fill;
                expense_ctl.isExpenseTab = true;
                expense_ctl.month = m;
                income_ctl.Dock = DockStyle.Fill;
                income_ctl.isExpenseTab = false;
                income_ctl.month = m;

                //Add filecontents to month tabs if necessary
                if (fileContent != null)
                {
                    foreach (String entry in fileContent[m])
                    {
                        String type = entry.Split(',')[0];
                        String date = entry.Split(',')[1];
                        String desc = entry.Split(',')[2];
                        String amnt = entry.Split(',')[3];
                        String catg = entry.Split(',')[4];

                        if (type == "expense")
                        {
                            expense_ctl.AddRow(date, desc, amnt, catg);
                        }
                        else if (type == "income")
                        {
                            income_ctl.AddRow(date, desc, amnt, catg);
                        }
                    }
                }

                //Setup Summary Section
                Dictionary<String,String> exp_sum = new Dictionary<String,String>();
                Dictionary<String, String> inc_sum = new Dictionary<String, String>();
                if(summaryContent != null)
                {
                    foreach(String sum_raw in summaryContent[m])
                    {
                        if (sum_raw.Split(',')[0] == "expense")
                        {
                            exp_sum[sum_raw.Split(',')[2]] = sum_raw.Split(',')[3];
                        }
                        else if(sum_raw.Split(',')[0] == "income")
                        {
                            inc_sum[sum_raw.Split(',')[2]] = sum_raw.Split(',')[3];
                        }
                    }
                }
                expense_ctl.SetupSummarySection(exp_sum);
                income_ctl.SetupSummarySection(inc_sum);

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

        private static String filePath = String.Empty;
        private static String fileName = String.Empty;
        private static bool fileEdited = false;
        public static bool FileEdited
        {
            get
            {
                return fileEdited;
            }
            set
            {
                if(!fileEdited && value)
                {
                    Program.mainWindow.Text = fileName + "*";
                }
                else if(fileEdited && !value)
                {
                    Program.mainWindow.Text = fileName;
                }
                fileEdited = value;
            }
        }

        private void open_Clicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "Documents";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    Dictionary<String, List<String>> fileContent = new Dictionary<string, List<string>>();
                    Dictionary<String, List<String>> summaryContent = new Dictionary<string, List<string>>();
                    foreach(String month in Global.Months)
                    {
                        fileContent.Add(month, new List<String>());
                        summaryContent.Add(month, new List<String>());
                    }

                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader savefile = new StreamReader(fileStream))
                    {
                        String tmp;
                        while( (tmp = savefile.ReadLine()) != null)
                        {
                            String type = tmp.Split(',')[0];
                            if (type == "summary")
                            {
                                tmp = tmp.Substring(8); //remove summary tag
                                summaryContent[tmp.Split(',')[1]].Add(tmp);
                            }
                            else if (type == "item")
                            {
                                tmp = tmp.Substring(5); //remove item tag
                                String date = tmp.Split(',')[1];
                                fileContent[Global.Months[int.Parse(date.Substring(0, 2)) - 1]].Add(tmp);
                            }
                        }

                    }
                    setupTabs(fileContent, summaryContent);

                    fileName = Regex.Split(filePath, @"\\").Last();
                    this.Text = fileName;
                }
            }
            return;
        }

        private void save_Clicked(object sender, EventArgs e)
        {
            Stream filestream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            DialogResult dialogresult = saveFileDialog1.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                if ((filestream = saveFileDialog1.OpenFile()) != null)
                {
                    var savefile = new StreamWriter(filestream);

                    foreach (TabPage mon in tc_TabController.TabPages)
                    {
                        if (Global.Months.Contains(mon.Text))
                        {
                            //save the expense tab
                            Month_tab expenses = (((mon.Controls[0] as TabControl).TabPages[0]).Controls[0] as Month_tab);
                            foreach (Row_item it in expenses.GetRows())
                            {
                                savefile.Write("item,");
                                savefile.Write("expense,");
                                savefile.Write(it.GetDate() + ",");
                                savefile.Write(it.GetDescription() + ",");
                                savefile.Write(it.GetAmount() + ",");
                                savefile.Write(it.GetCategory());
                                savefile.Write("\r\n");
                            }
                            foreach ((String category, String planned) in expenses.GetSummarySaveData())
                            {
                                savefile.Write("summary,");
                                savefile.Write("expense,");
                                savefile.Write(mon.Text + ",");
                                savefile.Write(category + ",");
                                savefile.Write(planned + ",");
                                savefile.Write("\r\n");
                            }

                            //save the income tab
                            Month_tab incomes = (((mon.Controls[0] as TabControl).TabPages[1]).Controls[0] as Month_tab);
                            foreach (Row_item it in incomes.GetRows())
                            {
                                savefile.Write("item,");
                                savefile.Write("income,");
                                savefile.Write(it.GetDate() + ",");
                                savefile.Write(it.GetDescription() + ",");
                                savefile.Write(it.GetAmount() + ",");
                                savefile.Write(it.GetCategory());
                                savefile.Write("\r\n");
                            }
                            foreach ((String category, String planned) in incomes.GetSummarySaveData())
                            {
                                savefile.Write("summary,");
                                savefile.Write("income,");
                                savefile.Write(mon.Text + ",");
                                savefile.Write(category + ",");
                                savefile.Write(planned + ",");
                                savefile.Write("\r\n");
                            }
                        }
                    }
                    savefile.Close();
                    filestream.Close();
                    MainForm.FileEdited = false;
                }
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                if(e.GetType().Equals(typeof(FormClosingEventArgs)))
                {
                    FormClosingEventArgs e_cast = (FormClosingEventArgs)e;
                    e_cast.Cancel = true;
                }
            }
            return;
        }

        private void exit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainForm.fileEdited)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save first?", "Save?", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

                if (dialogResult == DialogResult.Yes)
                {
                    save_Clicked(this, e);
                }
            }
        }
    }
}
