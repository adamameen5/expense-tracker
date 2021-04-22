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
    public partial class FormContacts : Form
    {

        public ExpenseGuide UserDataSet { get; set; }

        //Creating a dataset instance
        ExpenseGuide myDataSet = new ExpenseGuide();


        /*
         * Deafult form constructor
         */
        public FormContacts()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            if (File.Exists("ExpenseGuide-Contact-Details.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide-Contact-Details.xml");
            }
        }


        private void toggleAddNewPayorView(object sender, EventArgs e)
        {

            FormAddNewPayor formPayor = new FormAddNewPayor();
            formPayor.ShowDialog();

        }


        private void toggleAddNewPayeeView(object sender, EventArgs e)
        {
            FormAddNewPayee formPayee = new FormAddNewPayee();
            formPayee.ShowDialog();

        }


        private void FormContacts_Load(object sender, EventArgs e)
        {
            RefreshPayorData();  
        }


        private void dataGridPayor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("test");
        }


        private void editPayor(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("test");
            DataGridViewRow getRow = dataGridPayor.Rows[e.RowIndex];
            Console.WriteLine(this.dataGridPayor.CurrentRow.Cells[0].Value.ToString());
            Console.WriteLine(this.dataGridPayor.CurrentRow.Cells[1].Value.ToString());
        }


        public void RefreshPayorData()
        {
            ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

            var custQuery =
                from cust in db.Contacts
                where cust.UserId == FormLogin.globalLoggedInUserID && cust.ContactType == "Payor"
                select new
                {
                    ID = cust.Id,
                    Name = cust.ContactName,
                    Description = cust.ContactDescription,
                    TelephoneNumber = cust.ContactTelephoneNumber,
                    Type = cust.ContactType
                };

            dataGridPayor.DataSource = custQuery.ToList();
            dataGridPayor.Columns[0].Visible = false;
        }


        public void RefreshPayeeData()
        {
            ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

            var custQuery =
                from cust in db.Contacts
                where cust.UserId == FormLogin.globalLoggedInUserID && cust.ContactType == "Payee"
                select new
                {
                    ID = cust.Id,
                    Name = cust.ContactName,
                    Description = cust.ContactDescription,
                    TelephoneNumber = cust.ContactTelephoneNumber,
                    Type = cust.ContactType
                };

            dataGridPayee.DataSource = custQuery.ToList();
            dataGridPayee.Columns[0].Visible = false;
        }


        private void refreshData(object sender, EventArgs e)
        {
            RefreshPayorData();
            RefreshPayeeData();
        }

        private void LoadContactsData(object sender, EventArgs e)
        {

        }


        private void TabControlChanged(object sender, EventArgs e)
        {
            if (tabContacts.SelectedIndex == 0){
                RefreshPayorData();
            } else if(tabContacts.SelectedIndex == 1)
            {
                RefreshPayeeData();
            }
        }
    }
}
