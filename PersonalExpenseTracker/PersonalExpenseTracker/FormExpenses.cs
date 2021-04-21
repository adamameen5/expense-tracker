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
    public partial class FormExpenses : Form
    {
        public FormExpenses()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
        }

        private void toggleAddNewExpense(object sender, EventArgs e)
        {
            FormAddNewExpense formAddNewExpns = new FormAddNewExpense();
            formAddNewExpns.Show();
            this.Hide();
        }
    }
}
