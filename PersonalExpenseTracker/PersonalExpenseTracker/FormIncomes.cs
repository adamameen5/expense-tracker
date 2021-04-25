using ClosedXML.Excel;
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

        String incomeIdToUpdate = "";
        String incomeCodeToUpdate = "";
        String incomeDateToUpdate = "";
        String incomeContactNameToUpdate = "";
        String incomeAmountToUpdate = "";
        String incomeEventToUpdate = "";
        String incomeAssociatedAccountToUpdate = "";

        ExpenseGuide myDataSet = new ExpenseGuide();

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

        private void UpdateIncomeRecord(object sender, EventArgs e)
        {
            FormAddNewIncome formAddNewIncm = new FormAddNewIncome();
            formAddNewIncm.PopulateFieldsToUpdate(incomeIdToUpdate, incomeDateToUpdate, incomeContactNameToUpdate, incomeAmountToUpdate, incomeEventToUpdate, incomeAssociatedAccountToUpdate, incomeCodeToUpdate);
            DialogResult result = formAddNewIncm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                RefreshIncomesData();
            }
        }

        private void GetRowContent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow getRow = dataGridIncomes.Rows[e.RowIndex];
            incomeIdToUpdate = this.dataGridIncomes.CurrentRow.Cells[0].Value.ToString();
            incomeDateToUpdate = this.dataGridIncomes.CurrentRow.Cells[1].Value.ToString();
            incomeContactNameToUpdate = this.dataGridIncomes.CurrentRow.Cells[2].Value.ToString();
            incomeAmountToUpdate = this.dataGridIncomes.CurrentRow.Cells[3].Value.ToString();
            incomeEventToUpdate = this.dataGridIncomes.CurrentRow.Cells[4].Value.ToString();
            incomeAssociatedAccountToUpdate = this.dataGridIncomes.CurrentRow.Cells[5].Value.ToString();
            incomeCodeToUpdate = this.dataGridIncomes.CurrentRow.Cells[6].Value.ToString();
            btnUpdateRecord.Visible = true;
        }


        private void GenerateIncomeReport(object sender, EventArgs e)
        {
            ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(this.myDataSet.Transaction.Where(x => x.FK_UserID == FormLogin.globalLoggedInUserID && x.TransactionType == "Income").CopyToDataTable(), "Transaction");
                                workbook.SaveAs(sfd.FileName);
                            }
                            MessageBox.Show("You have Successfully Downloaded the Report", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
