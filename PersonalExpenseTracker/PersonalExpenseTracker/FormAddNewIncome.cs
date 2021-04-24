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
    public partial class FormAddNewIncome : Form
    {
        public int currentUserId = FormLogin.globalLoggedInUserID;
        private readonly IncomeModel helper = new IncomeModel();
        public int transactionAssociatedContactID = 0;
        public UserTransactionsData userTransactionsData { get; set; }
        public int incomeIdToUpdate = 0;
        public Boolean isAnUpdate = false;

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormAddNewIncome()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            incomeCode.Text = helper.GetTransactionCode();
            LoadComboBoxPayorData();
            LoadComboBoxEventData();
            LoadComboBoxAccountData();
        }

        private void goBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirmWindow = MessageBox.Show(Properties.Resources.RedirectToDashboardConfirmationMessage,
                                     "Confirm Redirection!",
                                     MessageBoxButtons.YesNo);

            if (confirmWindow == DialogResult.Yes)
            {
                FormDashboard formDash = new FormDashboard();
                formDash.Show();
                this.Hide();
            }
        }

        private void validateIncomeInfo(object sender, EventArgs e)
        {
            String txtIncomeCode = "";
            String txtIncomeDate = "";
            String txtIncomePayor = "";
            String txtIncomeAmount = "";
            String txtIncomeEvent = "";
            String txtIncomeAccount = "";

            txtIncomeCode = this.incomeCode.Text.Trim();
            txtIncomeDate = this.incomeDate.Text.Trim();
            txtIncomePayor = this.incomePayor.Text.Trim();
            txtIncomeAmount = this.incomeAmount.Text.Trim();
            txtIncomeEvent = this.incomeEvent.Text.Trim();
            txtIncomeAccount = this.incomeAccount.Text.Trim();

            if (txtIncomeCode == "" || txtIncomeDate == "" || txtIncomePayor == "" || txtIncomeAmount == "" || txtIncomeEvent == "" || txtIncomeAccount == "")
            {
                MessageBox.Show(String.Format(Properties.Resources.ALL_FIELDS_REQUIRED_MESSAGE), "Fields required");
                return;
            }
            else
            {
                if (!isAnUpdate)
                {
                    SaveIncomeInfo();
                }
                else
                {
                    UpdateIncomeInfo();
                }
            }
        }


        private void UpdateIncomeInfo()
        {
            Boolean transactionSaved = false;

            this.userTransactionsData = new UserTransactionsData();
            this.userTransactionsData.transactionDate = this.incomeDate.Text.Trim();
            this.userTransactionsData.transactionContactName = this.incomePayor.Text.Trim();
            this.userTransactionsData.transactionAmount = this.incomeAmount.Text.Trim();
            this.userTransactionsData.transactionEvent = this.incomeEvent.Text.Trim();
            this.userTransactionsData.transactionAssociatedAccount = this.incomeAccount.Text.Trim();
            this.userTransactionsData.transactionType = "Income";
            this.userTransactionsData.transactionCode = this.incomeCode.Text.Trim();


            ////add the data onto the memory resident database
            //ExpenseGuide.TransactionRow transactionRow = this.myDataSet.Transaction.FindByTransactionID(incomeIdToUpdate);
            //transactionRow.TransactionDate = this.userTransactionsData.transactionDate;
            //transactionRow.TransactionContactName = this.userTransactionsData.transactionContactName;
            //transactionRow.TransactionAmount = this.userTransactionsData.transactionAmount;
            //transactionRow.TransactionEvent = this.userTransactionsData.transactionEvent;
            //transactionRow.TransactionAssociatedAccount = this.userTransactionsData.transactionAssociatedAccount;
            //transactionRow.TransactionType = this.userTransactionsData.transactionType;
            //transactionRow.TransactionCode = this.userTransactionsData.transactionCode;
            //transactionRow.FK_UserID = currentUserId;
            //transactionRow.FK_ContactID = transactionAssociatedContactID;

            //// adding the data to the respective instances
            //this.myDataSet.Transaction.AddTransactionRow(transactionRow);
            //this.myDataSet.AcceptChanges();

            ////serialize it to disc
            //this.myDataSet.WriteXml("ExpenseGuide.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db


            transactionSaved = helper.UpdateIncomeInfo(incomeIdToUpdate, userTransactionsData);

            if (transactionSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.INCOME_DETAILS_SUCCESSFULLY_UPDATED), "Update Success");

                ResetTextFields();
                incomeCode.Text = helper.GetTransactionCode();
            }
        }


        private void LoadComboBoxPayorData()
        {
            List<String> payorData = new List<String>();
            payorData = helper.GetListOfPayor();

            foreach (String item in payorData)
            {
                incomePayor.Items.Add(item);
            }
        }


        private void LoadComboBoxEventData()
        {
            List<String> eventData = new List<String>();
            eventData = helper.GetListOfEvents();

            foreach (String item in eventData)
            {
                incomeEvent.Items.Add(item);
            }
        }


        private void LoadComboBoxAccountData()
        {
            List<String> accountData = new List<String>();
            accountData = helper.GetListOfAccounts();

            foreach (String item in accountData)
            {
                incomeAccount.Items.Add(item);
            }
        }


        private void SaveIncomeInfo()
        {
            Boolean transactionSaved = false;

            this.userTransactionsData = new UserTransactionsData();
            this.userTransactionsData.transactionDate = this.incomeDate.Text.Trim();
            this.userTransactionsData.transactionContactName = this.incomePayor.Text.Trim();
            this.userTransactionsData.transactionAmount = this.incomeAmount.Text.Trim();
            this.userTransactionsData.transactionEvent = this.incomeEvent.Text.Trim();
            this.userTransactionsData.transactionAssociatedAccount = this.incomeAccount.Text.Trim();
            this.userTransactionsData.transactionType = "Income";
            this.userTransactionsData.transactionCode = this.incomeCode.Text.Trim();


            //add the data onto the memory resident database
            ExpenseGuide.TransactionRow transactionRow = this.myDataSet.Transaction.NewTransactionRow();
            transactionRow.TransactionDate = this.userTransactionsData.transactionDate;
            transactionRow.TransactionContactName = this.userTransactionsData.transactionContactName;
            transactionRow.TransactionAmount = this.userTransactionsData.transactionAmount;
            transactionRow.TransactionEvent = this.userTransactionsData.transactionEvent;
            transactionRow.TransactionAssociatedAccount = this.userTransactionsData.transactionAssociatedAccount;
            transactionRow.TransactionType = this.userTransactionsData.transactionType;
            transactionRow.TransactionCode = this.userTransactionsData.transactionCode;
            transactionRow.FK_UserID = currentUserId;
            transactionRow.FK_ContactID = transactionAssociatedContactID;

            // adding the data to the respective instances
            this.myDataSet.Transaction.AddTransactionRow(transactionRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.Contact.WriteXml("ExpenseGuide.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db


            transactionSaved = helper.SaveIncomeInfo(transactionAssociatedContactID, userTransactionsData);

            if (transactionSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.INCOME_DETAILS_SUCCESSFULLY_SAVED), "Success");

                ResetTextFields();
                incomeCode.Text = helper.GetTransactionCode();
            }
        }


        private void ResetTextFields()
        {
            this.incomeCode.Text = "";
            this.incomeDate.Text = "";
            this.incomePayor.Text = "";
            this.incomeAmount.Text = "";
            this.incomeEvent.Text = "";
            this.incomeAccount.Text = "";
            transactionAssociatedContactID = 0;
        }

        private void onChangePayorDropdown(object sender, EventArgs e)
        {
            transactionAssociatedContactID = helper.GetContactID(incomePayor.Text.Trim());
        }


        public void PopulateFieldsToUpdate(String incID, String incDate, String incContact, String incAmount, String incEvent, String incAccount, String incCode)
        {

            incomeIdToUpdate = Int32.Parse(incID);
            incomeDate.Text = incDate;
            incomePayor.Text = incContact;
            incomeAmount.Text = incAmount;
            incomeEvent.Text = incEvent;
            incomeAccount.Text = incAccount;
            incomeCode.Text = incCode;
            isAnUpdate = true;
        }
    }
}
