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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
        }

        private void toggleUserInfoView(object sender, EventArgs e)
        {
            
        }

        private void toggleContactsView(object sender, EventArgs e)
        {
            FormContacts contactsView = new FormContacts();
            contactsView.Show();
            this.Hide();
        }

        private void toggleExpensesView(object sender, EventArgs e)
        {
            FormExpenses formExpense = new FormExpenses();
            formExpense.Show();
            this.Hide();
        }

        private void toggleIncomesView(object sender, EventArgs e)
        {
            FormIncomes formIncome = new FormIncomes();
            formIncome.Show();
            this.Hide();
        }

        private void togglePredictorView(object sender, EventArgs e)
        {
            FormPredictor formPredict = new FormPredictor();
            formPredict.Show();
            this.Hide();
        }

        private void toggleEventsView(object sender, EventArgs e)
        {
            FormEvents formEvent = new FormEvents();
            formEvent.Show();
            this.Hide();
        }
    }
}
