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
    public partial class FormAddNewPayee : Form
    {
        public FormAddNewPayee()
        {
            InitializeComponent();
        }

        private void goBackToDashboard(object sender, EventArgs e)
        {
            FormDashboard formDash = new FormDashboard();
            formDash.Show();

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "FormDashboard")
                    f.Close();
            }
        }

        private void goBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDashboard formDash = new FormDashboard();
            formDash.Show();

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "FormDashboard")
                    f.Close();
            }
        }
    }
}
