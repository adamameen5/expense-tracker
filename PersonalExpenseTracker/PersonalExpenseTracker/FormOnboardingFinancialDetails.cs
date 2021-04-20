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

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormOnboardingFinancialDetails()
        {
            InitializeComponent();
        }

        private void enterFinancialDetails(object sender, EventArgs e)
        {
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
            cardDetailRow.FK_UserID = FormSignUp.glblUserID;


            // adding the data to the respective instances
            this.myDataSet.CardDetail.AddCardDetailRow(cardDetailRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.CardDetail.WriteXml("ExpenseGuide-Card-Details.xml");


            glblUserID = FormSignUp.glblUserID;

            //forwarding - interacting with the model class, saving the data permanently in the db
            UserModel userModel = new UserModel();
            userModel.saveCardDetails(glblUserID, cardDetailData);

            //show confirmation message on success
            MessageBox.Show(String.Format(Properties.Resources.SIGN_UP_SUCCESSFUL_MESSAGE));

            //Show the dashboard
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}
