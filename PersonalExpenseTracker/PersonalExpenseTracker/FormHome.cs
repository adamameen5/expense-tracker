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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void toggleLoginView(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
            
        }

        private void toggleSignUpView(object sender, EventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp();
            signUpForm.Show();
            this.Hide();
            
        }
    }
}
