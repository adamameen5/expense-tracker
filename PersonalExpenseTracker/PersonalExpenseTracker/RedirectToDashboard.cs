using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    class RedirectToDashboard
    {
        public void goBackToDashboard()
        {
            var confirmWindow = MessageBox.Show(Properties.Resources.RedirectToDashboardConfirmationMessage,
                                     "Confirm Redirection!",
                                     MessageBoxButtons.YesNo);
            if (confirmWindow == DialogResult.Yes)
            {
                FormDashboard formDash = new FormDashboard();
                formDash.Show();

                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                {
                    openForms.Add(f);
                }

                foreach (Form f in openForms)
                {
                    if (f.Name != "FormDashboard")
                        f.Close();
                }
            }

        }
    }
}
