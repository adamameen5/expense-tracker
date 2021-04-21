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
    public partial class FormIncomes : Form
    {
        public FormIncomes()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
        }

        private void toggleAddNewIncome(object sender, EventArgs e)
        {
            FormAddNewIncome formAddNewIncome = new FormAddNewIncome();
            formAddNewIncome.Show();
            this.Hide();
        }
    }
}
