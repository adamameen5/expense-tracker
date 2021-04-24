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
    public partial class FormIncomes : Form
    {
        public FormIncomes()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            RefreshIncomesData();
        }

        private void toggleAddNewIncome(object sender, EventArgs e)
        {
            FormAddNewIncome formAddNewIncome = new FormAddNewIncome();
            DialogResult result = formAddNewIncome.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                RefreshIncomesData();
            }
        }


        public void RefreshIncomesData()
        {
            ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

            var incomesQuery =
                from incomes in db.Transactions
                where incomes.UserId == FormLogin.globalLoggedInUserID && incomes.TransactionType == "Income"
                select new
                {
                    ID = incomes.Id,
                    Date = incomes.TransactionDate,
                    PaidFor = incomes.TransactionContactName,
                    Amount = incomes.TransactionAmount,
                    Event = incomes.TransactionEvent,
                    FromAccount = incomes.TransactionAssociatedAccount,
                    TransactionCode = incomes.TransactionCode,
                    ContactId = incomes.ContactId
                };

            dataGridIncomes.DataSource = incomesQuery.ToList();
            dataGridIncomes.Columns[0].Visible = false;
            dataGridIncomes.Columns[7].Visible = false;
        }
    }
}
