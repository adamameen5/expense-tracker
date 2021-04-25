using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormAddNewExpense : Form
    {
        public int currentUserId = FormLogin.globalLoggedInUserID;
        private readonly ExpenseModel helper = new ExpenseModel();
        public int transactionAssociatedContactID = 0;
        public UserTransactionsData userTransactionsData { get; set; }
        public int expenseIdToUpdate = 0;
        public Boolean isAnUpdate = false;

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormAddNewExpense()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;            
            expenseCode.Text = helper.GetTransactionCode();
            LoadComboBoxPayeeData();
            LoadComboBoxEventData();
            LoadComboBoxAccountData();

            if (File.Exists("ExpenseGuide.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide.xml");
            }
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

        private void LoadComboBoxPayeeData()
        {
            List<String> payeeData = new List<String>();
            payeeData = helper.GetListOfPayee();

            foreach ( String item in payeeData)
            {
                expensePayee.Items.Add(item);
            }
        }


        private void LoadComboBoxEventData()
        {
            List<String> eventData = new List<String>();
            eventData = helper.GetListOfEvents();

            foreach (String item in eventData)
            {
                expenseEvent.Items.Add(item);
            }
        }


        private void LoadComboBoxAccountData()
        {
            List<String> accountData = new List<String>();
            accountData = helper.GetListOfAccounts();

            foreach (String item in accountData)
            {
                expenseAccount.Items.Add(item);
            }
        }


        private void validateExpenseInfo(object sender, EventArgs e)
        {
            String txtExpenseCode = "";
            DateTime txtExpenseDate = new DateTime();
            String txtExpensePayee = "";
            String txtExpenseAmount = "";
            String txtExpenseEvent = "";
            String txtExpenseAccount = "";

            txtExpenseCode = this.expenseCode.Text.Trim();
            txtExpenseDate = this.expenseDate.Value;
            txtExpensePayee = this.expensePayee.Text.Trim();
            txtExpenseAmount = this.expenseAmount.Text.Trim();
            txtExpenseEvent = this.expenseEvent.Text.Trim();
            txtExpenseAccount = this.expenseAccount.Text.Trim();

            if (txtExpenseCode == "" || txtExpenseDate == null || txtExpensePayee == "" || txtExpenseAmount == "" || txtExpenseEvent == "" || txtExpenseAccount == "")
            {
                MessageBox.Show(String.Format(Properties.Resources.ALL_FIELDS_REQUIRED_MESSAGE), "Fields required");
                return;
            }
            else
            {
                if (!isAnUpdate)
                {
                    SaveExpenseInfo();
                } else
                {
                    UpdateExpenseInfo();
                }
                
            }
        }


        private void SaveExpenseInfo()
        {
            Boolean transactionSaved = false;

            this.userTransactionsData = new UserTransactionsData();
            this.userTransactionsData.transactionDate = this.expenseDate.Value;
            this.userTransactionsData.transactionContactName = this.expensePayee.Text.Trim();
            this.userTransactionsData.transactionAmount = this.expenseAmount.Text.Trim();
            this.userTransactionsData.transactionEvent = this.expenseEvent.Text.Trim();
            this.userTransactionsData.transactionAssociatedAccount = this.expenseAccount.Text.Trim();
            this.userTransactionsData.transactionType = "Expense";
            this.userTransactionsData.transactionCode = this.expenseCode.Text.Trim();


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
            this.myDataSet.WriteXml("ExpenseGuide.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db


            transactionSaved = helper.SaveExpenseInfo(transactionAssociatedContactID, userTransactionsData);

            if (transactionSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.EXPENSE_DETAILS_SUCCESSFULLY_SAVED), "Insert Success");

                ResetTextFields();
                expenseCode.Text = helper.GetTransactionCode();
            }
        }


        private void UpdateExpenseInfo()
        {
            Boolean transactionSaved = false;

            this.userTransactionsData = new UserTransactionsData();
            this.userTransactionsData.transactionDate = this.expenseDate.Value;
            this.userTransactionsData.transactionContactName = this.expensePayee.Text.Trim();
            this.userTransactionsData.transactionAmount = this.expenseAmount.Text.Trim();
            this.userTransactionsData.transactionEvent = this.expenseEvent.Text.Trim();
            this.userTransactionsData.transactionAssociatedAccount = this.expenseAccount.Text.Trim();
            this.userTransactionsData.transactionType = "Expense";
            this.userTransactionsData.transactionCode = this.expenseCode.Text.Trim();


            //add the data onto the memory resident database
            ExpenseGuide.TransactionRow transactionRow = this.myDataSet.Transaction.FindByTransactionID(expenseIdToUpdate);
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
            this.myDataSet.WriteXml("ExpenseGuide.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db


            transactionSaved = helper.UpdateExpenseInfo(expenseIdToUpdate, userTransactionsData);

            if (transactionSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.EXPENSE_DETAILS_SUCCESSFULLY_UPDATED), "Update Success");

                ResetTextFields();
                expenseCode.Text = helper.GetTransactionCode();
            }
        }

        private void OnChangePayeeDropdown(object sender, EventArgs e)
        {
            transactionAssociatedContactID = helper.GetContactID(expensePayee.Text.Trim());
        }


        private void ResetTextFields()
        {
            this.expenseCode.Text = "";
            this.expenseDate.Text = "";
            this.expensePayee.Text = "";
            this.expenseAmount.Text = "";
            this.expenseEvent.Text = "";
            this.expenseAccount.Text = "";
            transactionAssociatedContactID = 0;
        }
        

        public void PopulateFieldsToUpdate(String expID, String expDate, String expContact, String expAmount, String expEvent, String expAccount , String expCode)
        {

            expenseIdToUpdate = Int32.Parse(expID);
            expenseDate.Text = expDate;
            expensePayee.Text = expContact;
            expenseAmount.Text = expAmount;
            expenseEvent.Text = expEvent; 
            expenseAccount.Text = expAccount;
            expenseCode.Text = expCode;
            isAnUpdate = true;
        }
    }
}
