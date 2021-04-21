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
    public partial class FormOnBoardingPersonalDetails : Form
    {
        public int UserID = FormSignUp.glblUserID;
        public UserDetails userDetailsData { get; set; }    
        public FormOnBoardingPersonalDetails()
        {
            InitializeComponent();
        }

        private void enterPersonalDetails(object sender, EventArgs e)
        {
            this.userDetailsData = new UserDetails();
            this.userDetailsData.fullName = fullName.Text.Trim();
            this.userDetailsData.contact = phoneNumber.Text.Trim();
            this.userDetailsData.recoveryEmailAddress = recoveryEmailAddress.Text.Trim();
            this.userDetailsData.dateOfBirth = dateOfBirth.Text.Trim();

            UserModel userModel = new UserModel();
            userModel.updateUserInformation(UserID, this.userDetailsData);

            //show confirmation message on success
            MessageBox.Show(String.Format(Properties.Resources.PERSONAL_DETAILS_SUCCESSFULLY_ADDED));

            FormOnboardingFinancialDetails frm2 = new FormOnboardingFinancialDetails();
            frm2.Show();
            this.Hide();
        }
    }
}
