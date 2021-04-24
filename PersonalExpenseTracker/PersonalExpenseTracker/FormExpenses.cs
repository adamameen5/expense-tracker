using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormExpenses : Form
    {
        public FormExpenses()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            RefreshExpensesData();
        }

        private void toggleAddNewExpense(object sender, EventArgs e)
        {
            FormAddNewExpense formAddNewExpns = new FormAddNewExpense();
            DialogResult result = formAddNewExpns.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                RefreshExpensesData();
            }
        }


        public void RefreshExpensesData()
        {
            ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

            var expenseQuery =
                from expenses in db.Transactions
                where expenses.UserId == FormLogin.globalLoggedInUserID && expenses.TransactionType == "Expense"
                select new
                {
                    ID = expenses.Id,
                    Date = expenses.TransactionDate,
                    PaidFor = expenses.TransactionContactName,
                    Amount = expenses.TransactionAmount,
                    Event = expenses.TransactionEvent,
                    FromAccount = expenses.TransactionAssociatedAccount,
                    TransactionCode = expenses.TransactionCode,
                    ContactId = expenses.ContactId
                };

            dataGridExpenses.DataSource = expenseQuery.ToList();
            dataGridExpenses.Columns[0].Visible = false;
            dataGridExpenses.Columns[7].Visible = false;
        }
    }
}
