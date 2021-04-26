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
    public partial class FormAddNewPayor : Form
    {
        public UserContactsData userContactsData { get; set; }

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormAddNewPayor()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;

            if (File.Exists("ExpenseGuide.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide.xml");
            }
        }

        private void validatePayorInfo(object sender, EventArgs e)
        {

            String txtPayorName = "";
            String txtPayorDescription = "";
            String txtPayorTelephone = "";

            txtPayorName = this.payorName.Text.Trim();
            txtPayorDescription = this.payorDescription.Text.Trim();
            txtPayorTelephone = this.payorTelephoneNumber.Text.Trim();

            if (txtPayorName == "" || txtPayorDescription == "" || txtPayorTelephone == "")
            {
                MessageBox.Show(String.Format(Properties.Resources.ALL_FIELDS_REQUIRED_MESSAGE), "Fields required");
                return;
            }
            else
            {
                addNewPayor();
                
            }            
        }

        private void addNewPayor()
        {
            Boolean contactSaved = false;

            this.userContactsData = new UserContactsData();
            this.userContactsData.contactName = this.payorName.Text.Trim();
            this.userContactsData.contactDescription = this.payorDescription.Text.Trim();
            this.userContactsData.contactTelephoneNumber = this.payorTelephoneNumber.Text.Trim();
            this.userContactsData.contactType = "Payor";

            //add the data onto the memory resident database
            ExpenseGuide.ContactRow contactRow = this.myDataSet.Contact.NewContactRow();
            contactRow.ContactName = this.userContactsData.contactName;
            contactRow.ContactDescription = this.userContactsData.contactDescription;
            contactRow.ContactType = this.userContactsData.contactType;
            contactRow.ContactTelephoneNumber = this.userContactsData.contactTelephoneNumber;
            contactRow.FK_UserID = FormLogin.globalLoggedInUserID;

            // adding the data to the respective instances
            this.myDataSet.Contact.AddContactRow(contactRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.WriteXml("ExpenseGuide.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db

            ContactsModel contactsModel = new ContactsModel();
            contactSaved = contactsModel.addContactRecord(FormLogin.globalLoggedInUserID, userContactsData);

            if (contactSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.PAYOR_DETAILS_SUCCESSFULLY_SAVED), "Success");
                
                resetTextFields();
            }
        }

        private void resetTextFields()
        {
            this.payorName.Text = "";
            this.payorDescription.Text = "";
            this.payorTelephoneNumber.Text = "";
        }
    }
}
