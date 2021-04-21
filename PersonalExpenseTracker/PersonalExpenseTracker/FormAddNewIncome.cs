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
    public partial class FormAddNewIncome : Form
    {
        public FormAddNewIncome()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
        }

        private void goBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RedirectToDashboard rtb = new RedirectToDashboard();
            rtb.goBackToDashboard();
        }
    }
}
