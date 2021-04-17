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
    public partial class FormContacts : Form
    {
        public FormContacts()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
        }

        private void toggleAddNewPayorView(object sender, EventArgs e)
        {
            FormAddNewPayor formPayor = new FormAddNewPayor();
            formPayor.ShowDialog();

        }

        private void toggleAddNewPayeeView(object sender, EventArgs e)
        {
            FormAddNewPayee formPayee = new FormAddNewPayee();
            formPayee.ShowDialog();
        }
    }
}
