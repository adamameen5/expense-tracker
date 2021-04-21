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
    public partial class UserControlBackToDashboardLink : UserControl
    {
        public UserControlBackToDashboardLink()
        {
            InitializeComponent();
        }

        private void linkBackToDashboard(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirmWindow = MessageBox.Show(Properties.Resources.RedirectToDashboardConfirmationMessage,
                                     "Confirm Redirection!",
                                     MessageBoxButtons.YesNo);

            if (confirmWindow == DialogResult.Yes)
            {
                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                {
                    openForms.Add(f);
                }

                foreach (Form f in openForms)
                {
                    f.Hide();
                }
                FormDashboard formDash = new FormDashboard();
                formDash.Show();
                
            }
        }
    }
}
