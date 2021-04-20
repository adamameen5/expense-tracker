using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormSignUp : Form
    {
        public UserDetails userDetailsData { get; set; }

        public UserCredentialsData userCredentialsData { get; set; }

        public static int glblUserID = 0;

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormSignUp()
        {
            InitializeComponent();
            //this.RestoreData();

            if (File.Exists("ExpenseGuide.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide.xml");
            }
        }

        private void validateUserInfo(object sender, EventArgs e)
        {
            this.userCredentialsData = new UserCredentialsData();
            this.userCredentialsData.userName = this.userName.Text;
            this.userCredentialsData.email = this.email.Text;
            this.userCredentialsData.nicNumber = this.nicNumber.Text;
            this.userCredentialsData.password = this.password.Text;

            //add the data onto the memory resident database
            ExpenseGuide.CredentialsRow credentialsRow = this.myDataSet.Credentials.NewCredentialsRow();
            credentialsRow.UserName = this.userCredentialsData.userName;
            credentialsRow.Email = this.userCredentialsData.email;
            credentialsRow.NIC = this.userCredentialsData.nicNumber;
            credentialsRow.Password = this.userCredentialsData.password;

            ExpenseGuide.UserRow userRow = this.myDataSet.User.NewUserRow();
            userRow.DateOfBirth = "to-be-filled";

            //setting the relationship
            //credentials table contains information regarding the user (UserID)
            credentialsRow.UserRow = userRow;

            // adding the data to the respective instances
            this.myDataSet.Credentials.AddCredentialsRow(credentialsRow);
            this.myDataSet.User.AddUserRow(userRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.WriteXml("ExpenseGuide.xml");
            this.myDataSet.Credentials.WriteXml("ExpenseGuide-Credentials.xml");

            //forwarding - interacting with the model class, saving the data permanently in the db
            UserModel userModel = new UserModel();
            glblUserID = userModel.saveUserInformation(this.userCredentialsData);

            //show confirmation message on success
            MessageBox.Show(String.Format(Properties.Resources.SIGN_UP_SUCCESSFUL_MESSAGE));

            //Show the on-boarding forms
            FormOnBoardingPersonalDetails formOnBoarding1 = new FormOnBoardingPersonalDetails();
            formOnBoarding1.Show();
            this.Hide();






        }

        private void RestoreData()
        {
            String s1 = "";
            String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FileStream file = new FileStream(myDocument + "\\SignUpDetails.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(file, Encoding.Unicode);

            if (sr.EndOfStream == false)
            {
                s1 = sr.ReadToEnd();
            }

            sr.Close();
            file.Close();

            if (s1 != "")
            {
                UserDetails ud = JsonConvert.DeserializeObject<UserDetails>(s1);
                this.userName.Text = ud.userName;
                this.email.Text = ud.email;
                this.nicNumber.Text = ud.nicNumber;
                this.password.Text = ud.password;
                this.confirmPassword.Text = ud.password;
            }
        }

        private void redirectToLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
