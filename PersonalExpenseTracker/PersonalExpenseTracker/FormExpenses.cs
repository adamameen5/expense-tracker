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
        String expenseIdToUpdate = "";
        String expenseCodeToUpdate = "";
        String expenseDateToUpdate = "";
        String expenseContactNameToUpdate = "";        
        String expenseAmountToUpdate = "";
        String expenseEventToUpdate = "";
        String expenseAssociatedAccountToUpdate = "";


        public FormExpenses()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            RefreshExpensesData();
            dataGridExpenses.ScrollBars = ScrollBars.Both;
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

        private void UpdateExpenseRecord(object sender, EventArgs e)
        {
            FormAddNewExpense formAddNewExpns = new FormAddNewExpense();
            formAddNewExpns.PopulateFieldsToUpdate(expenseIdToUpdate,expenseDateToUpdate, expenseContactNameToUpdate, expenseAmountToUpdate, expenseEventToUpdate, expenseAssociatedAccountToUpdate, expenseCodeToUpdate);
            DialogResult result = formAddNewExpns.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                RefreshExpensesData();
            }
        }

        private void GetRowContent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow getRow = dataGridExpenses.Rows[e.RowIndex];
            expenseIdToUpdate = this.dataGridExpenses.CurrentRow.Cells[0].Value.ToString();
            expenseDateToUpdate = this.dataGridExpenses.CurrentRow.Cells[1].Value.ToString();
            expenseContactNameToUpdate = this.dataGridExpenses.CurrentRow.Cells[2].Value.ToString();
            expenseAmountToUpdate = this.dataGridExpenses.CurrentRow.Cells[3].Value.ToString();
            expenseEventToUpdate = this.dataGridExpenses.CurrentRow.Cells[4].Value.ToString();
            expenseAssociatedAccountToUpdate = this.dataGridExpenses.CurrentRow.Cells[5].Value.ToString();
            expenseCodeToUpdate = this.dataGridExpenses.CurrentRow.Cells[6].Value.ToString();
            btnUpdateRecord.Visible = true;
        }
    }
}
