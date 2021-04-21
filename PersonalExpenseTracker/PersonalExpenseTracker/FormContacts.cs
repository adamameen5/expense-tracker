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

        public FormContacts()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            if (File.Exists("ExpenseGuide.xml") == true)
            {
                this.myDataSet.ReadXml("ExpenseGuide.xml");
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
            this.UserDataSet = this.myDataSet;
            this.expenseGuide = this.UserDataSet;
            this.dataGridPayor.DataSource = this.expenseGuide;
            this.dataGridPayor.DataMember = "Credentials";
        }

        private void dataGridPayor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}
