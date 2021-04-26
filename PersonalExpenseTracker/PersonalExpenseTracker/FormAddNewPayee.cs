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
    public partial class FormAddNewPayee : Form
    {
        public UserContactsData userContactsData { get; set; }

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        public FormAddNewPayee()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;

            if (File.Exists("ExpenseGuide.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide.xml");
            }
        }

        private void goBackToDashboard(object sender, EventArgs e)
        {
            FormDashboard formDash = new FormDashboard();
            formDash.Show();

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "FormDashboard")
                    f.Close();
            }
        }

        private void goBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDashboard formDash = new FormDashboard();
            formDash.Show();

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "FormDashboard")
                    f.Close();
            }
        }

        private void validatePayeeInfo(object sender, EventArgs e)
        {
            String txtPayeeName = "";
            String txtPayeeDescription = "";
            String txtPayeeTelephone = "";

            txtPayeeName = this.payeeName.Text.Trim();
            txtPayeeDescription = this.payeeDescription.Text.Trim();
            txtPayeeTelephone = this.payeeTelephoneNumber.Text.Trim();

            if (txtPayeeName== "" || txtPayeeDescription=="" || txtPayeeTelephone == "")
            {
                MessageBox.Show(String.Format(Properties.Resources.ALL_FIELDS_REQUIRED_MESSAGE), "Fields required");
                return;
            } else
            {
                addNewPayee();
            }

        }

        private void addNewPayee()
        {
            Boolean contactSaved = false;

            this.userContactsData = new UserContactsData();
            this.userContactsData.contactName = this.payeeName.Text.Trim();
            this.userContactsData.contactDescription = this.payeeDescription.Text.Trim();
            this.userContactsData.contactTelephoneNumber = this.payeeTelephoneNumber.Text.Trim();
            this.userContactsData.contactType = "Payee";

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
                MessageBox.Show(String.Format(Properties.Resources.PAYEE_DETAILS_SUCCESSFULLY_SAVED), "Success");

                resetTextFields();
            }
        }

        private void resetTextFields()
        {
            this.payeeName.Text = "";
            this.payeeDescription.Text = "";
            this.payeeTelephoneNumber.Text = "";
        }
    }
}
