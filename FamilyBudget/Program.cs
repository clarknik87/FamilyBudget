using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    static class Global
    {
        public static List<String> ExpenseCategories = new List<String>
        {
            "Other",
            "Rent",
            "Groceries",
            "Eating Out",
            "House Needs",
            "Car Needs",
            "Subscriptions",
            "Tithing/Charity",
            "Utilities",
            "Phone",
            "Loans",
            "Apparel/Cosmetics",
            "Entertainment",
            "Medical",
            "Baby",
            "Holiday/Gifts",
            "Therapy",
            "Art School",
            "Nik",
            "Anna",
            "Vacation"
        };

        public static List<String> IncomeCategories = new List<String>
        {

            "Other",
            "APG",
            "Anna's Art",
            "Gifts"
        };

        public static List<string> Months = new List<string>{
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
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
