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
    public partial class FormEvents : Form
    {
        public UserEventsData userEventsData { get; set; }

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();

        EventsModel helper = new EventsModel();

        public DateTime txtEventDate = new DateTime();
        public String txtEventCode = "";
        public String txtEventName = "";
        public String txtEventRecurring = "";
        public String txtEventType = "";
        public String txtEventCategory = "";
        public String txtEventAssociatedContact = "";
        public String contactTypeToShow = "All";

        public FormEvents()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            eventCode.Text = helper.GetEventCode();
            LoadComboBoxEventContactData(contactTypeToShow);
        }

        private void validateEventInfo(object sender, EventArgs e)
        {
            
            txtEventDate = this.eventDate.Value;
            txtEventCode = this.eventCode.Text.Trim();
            txtEventName = this.eventName.Text.Trim();

            if (eventRecurringEveryday.Checked)
            {
                txtEventRecurring = "Everyday";
            } else
            {
                txtEventRecurring = "Same day, every month";
            }

            if (eventTypeAppointment.Checked)
            {
                txtEventType = "Appointment";
            } else
            {
                txtEventType = "Task";
            } 


            if (eventCategoryExpense.Checked)
            {
                txtEventCategory = "Expense";
            }
            else if (evenCategoryIncome.Checked)
            {
                txtEventCategory = "Income";
            } else
            {
                txtEventCategory = "Just an event";
            }

            txtEventAssociatedContact = eventContact.Text;

            if (txtEventAssociatedContact == "" || txtEventCategory == "" || txtEventDate == null || txtEventName == "" || txtEventRecurring == "" || txtEventType == "")
            {
                MessageBox.Show(String.Format(Properties.Resources.ALL_FIELDS_REQUIRED_MESSAGE), "Fields required");
                return;
            }
            else
            {
                saveEventInfo();
            }
        }

        private void saveEventInfo()
        {
            Boolean eventSaved = false;

            this.userEventsData = new UserEventsData();
            this.userEventsData.eventDate = txtEventDate;
            this.userEventsData.eventCode = txtEventCode;
            this.userEventsData.eventName = txtEventName;
            this.userEventsData.eventRecurring = txtEventRecurring;
            this.userEventsData.eventType = txtEventType;
            this.userEventsData.eventCategory = txtEventCategory;
            this.userEventsData.eventAssociateContact = txtEventAssociatedContact;

            //add the data onto the memory resident database
            ExpenseGuide.EventRow eventRow = this.myDataSet.Event.NewEventRow();
            eventRow.EventDate = this.userEventsData.eventDate;
            eventRow.EventCode = this.userEventsData.eventCode;
            eventRow.EventName = this.userEventsData.eventName;
            eventRow.EventRecurring = this.userEventsData.eventRecurring;
            eventRow.EventType = this.userEventsData.eventType;
            eventRow.EventCategory = this.userEventsData.eventCategory;
            eventRow.EventAssociatedContact = this.userEventsData.eventAssociateContact;
            eventRow.FK_UserID = FormLogin.globalLoggedInUserID;

            // adding the data to the respective instances
            this.myDataSet.Event.AddEventRow(eventRow);
            this.myDataSet.AcceptChanges();

            //serialize it to disc
            this.myDataSet.Contact.WriteXml("ExpenseGuide-Event-Details.xml");

            //forwarding the data (interacting with the model class, saving the data permanently in the db)
            //here we save the contact details permanently in the db

            EventsModel eventsModel = new EventsModel();
            eventSaved = eventsModel.addEventRecord(FormLogin.globalLoggedInUserID, userEventsData);

            if (eventSaved)
            {
                //show success message if the data was added succesfully
                MessageBox.Show(String.Format(Properties.Resources.EVENT_DETAILS_SUCCESSFULLY_SAVED), "Success");

                resetTextFields();
            }
        }

        private void resetTextFields()
        {
            
        }


        private void LoadComboBoxEventContactData(String typeOfContact)
        {
            List<String> contactData = new List<String>();
            contactData = helper.GetListOfContacts(contactTypeToShow);

            foreach (String item in contactData)
            {
                eventContact.Items.Add(item);
            }
        }

        private void ExpenseChanged(object sender, EventArgs e)
        {
            eventContact.Text = "";
            eventContact.Items.Clear();
            contactTypeToShow = "Payee";
            LoadComboBoxEventContactData(contactTypeToShow);
        }

        private void IncomeChanged(object sender, EventArgs e)
        {
            eventContact.Text = "";
            eventContact.Items.Clear();
            contactTypeToShow = "Payor";
            LoadComboBoxEventContactData(contactTypeToShow);
        }

        private void JustAnEventChanged(object sender, EventArgs e)
        {
            eventContact.Text = "";
            eventContact.Items.Clear();
            contactTypeToShow = "All";
            LoadComboBoxEventContactData(contactTypeToShow);
        }

        private void ShowWeeklyView(object sender, EventArgs e)
        {
            FormWeeklyView frm = new FormWeeklyView();
            frm.Show();
            this.Hide();
        }
    }
}
