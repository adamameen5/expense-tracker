﻿using System;
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
    public partial class FormAddNewExpense : Form
    {
        public FormAddNewExpense()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
        }

        private void goBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var confirmWindow = MessageBox.Show(Properties.Resources.RedirectToDashboardConfirmationMessage,
                                     "Confirm Redirection!",
                                     MessageBoxButtons.YesNo);

            if (confirmWindow == DialogResult.Yes)
            {
                FormDashboard formDash = new FormDashboard();
                formDash.Show();
                this.Hide();
            }       
        }
    }
}
