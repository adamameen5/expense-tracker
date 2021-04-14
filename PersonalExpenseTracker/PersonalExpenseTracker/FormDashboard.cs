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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
        }

        private void openContactsView(object sender, EventArgs e)
        {
            FormContacts contactsView = new FormContacts();
            contactsView.Show();
            this.Hide();
        }
    }
}
