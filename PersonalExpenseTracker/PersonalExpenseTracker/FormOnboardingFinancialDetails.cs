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
    public partial class FormOnboardingFinancialDetails : Form
    {

        public static int glblUserID = 0;
        public UserCardDetailsData cardDetailData { get; set; }
        public UserBankAccountDetailsData bankAccountDetailsData { get; set; }

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormOnboardingFinancialDetails()
        {
            InitializeComponent();
        }

        private void enterFinancialDetails(object sender, EventArgs e)
        {
            glblUserID = FormSignUp.glblUserID;
            Boolean bankAccountSaved = false;
            Boolean cardSaved = false;

            /*
             * Logic to store bank account details
             */
            this.bankAccountDetailsData = new UserBankAccountDetailsData();
            this.bankAccountDetailsData.bankAccountBankName = this.bankAccountBankName.Text.Trim();
            this.bankAccountDetailsData.bankAccountBranchName = this.bankAccountBranchName.Text.Trim();
            this.bankAccountDetailsData.bankAccountNumber = this.bankAccountNumber.Text.Trim();
            this.bankAccountDetailsData.bankAccountNameToDisplay = this.bankAccountNameToDisplay.Text.Trim();

            //add the data onto the memory resident database
            ExpenseGuide.BankAccountDetailRow bankAccountDetailRow = this.myDataSet.BankAccountDetail.NewBankAccountDetailRow();
            bankAccountDetailRow.BankAccountBankName = this.bankAccountDetailsData.bankAccountBankName;
            bankAccountDetailRow.BankAccountBranchName = this.bankAccountDetailsData.bankAccountBranchName;
            bankAccountDetailRow.BankAccountNumber = this.bankAccountDetailsData.bankAccountNumber;
            bankAccountDetailRow.BankAccountNameToDisplay = this.bankAccountDetailsData.bankAccountNameToDisplay;
            bankAccountDetailRow.FK_UserID = glblUserID;

            // adding the data to the respective instances
            this.myDataSet.BankAccountDetail.AddBankAccountDetailRow(bankAccountDetailRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.BankAccountDetail.WriteXml("ExpenseGuide-Bank-Account-Details.xml");


            /*
             * Logic to store card details
             */
            this.cardDetailData = new UserCardDetailsData();
            this.cardDetailData.cardNumber = this.cardNumber.Text.Trim();
            this.cardDetailData.cardBankName = this.cardBankName.Text.Trim();
            this.cardDetailData.cardDateOfExpiry = this.cardDateOfExpiry.Text.Trim();
            this.cardDetailData.cardNameToDisplay = this.cardNameToDisplay.Text.Trim();

            //add the data onto the memory resident database
            ExpenseGuide.CardDetailRow cardDetailRow = this.myDataSet.CardDetail.NewCardDetailRow();
            cardDetailRow.CardNumber = this.cardDetailData.cardNumber;
            cardDetailRow.CardBankName = this.cardDetailData.cardBankName;
            cardDetailRow.CardDateOfExpiry = this.cardDetailData.cardDateOfExpiry;
            cardDetailRow.CardNameToDisplay = this.cardDetailData.cardNameToDisplay;
            cardDetailRow.FK_UserID = glblUserID;

            // adding the data to the respective instances
            this.myDataSet.CardDetail.AddCardDetailRow(cardDetailRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.CardDetail.WriteXml("ExpenseGuide-Card-Details.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the bank account details and card details permanently in the db

            AccountsModel accountsModel = new AccountsModel();

            bankAccountSaved = accountsModel.saveBankAccountDetails(glblUserID, bankAccountDetailsData);
            cardSaved = accountsModel.saveCardDetails(glblUserID, cardDetailData);

            if (bankAccountSaved && cardSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.FINANCIAL_DETAILS_SUCCESSFULLY_ADDED));

                //Show the login window
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
            
        }
    }
}
