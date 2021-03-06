using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormDashboard : Form
    {
        
        private FormWeeklyView _weeklyViewController;
        public int countOfControls = 0;
        public FormDashboard()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;

            _weeklyViewController = new FormWeeklyView();

            //var c = GetAll(this, typeof(Button));
            //MessageBox.Show("Total Controls: " + c.Count());

            //countOfControls = c.Count();
        }


        //private void DoWork()
        //{
        //    Thread[] threads = new Thread[countOfControls];
        //    for (int i=0; i<threads.Length; i++)
        //    {
        //        threads[i] = new Thread(new ThreadStart(myThreadMethod));
        //        threads[i].Start();
        //    }
        //}

        //public void myThreadMethod()
        //{
        //    doDisplay()
        //}


        //public IEnumerable<Control> GetAll(Control control, Type type)
        //{
        //    var controls = control.Controls.Cast<Control>();

        //    return controls.SelectMany(ctrl => GetAll(ctrl, type))
        //                              .Concat(controls)
        //                              .Where(c => c.GetType() == type);
        //}


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

        private void Logout(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();
        }
    }
}
