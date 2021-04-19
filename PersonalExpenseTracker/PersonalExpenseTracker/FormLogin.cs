using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormLogin : Form
    {
        public static int globalLoggedInUserID = 0;
        public static String globalLoggedInUserName = "";

        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void verifyCredentials(object sender, EventArgs e)
        {
            
            String emailTXT = email.Text.Trim();
            String passwordTXT = password.Text.Trim();

            if (emailTXT.Equals("") || passwordTXT.Equals(""))
            {
                MessageBox.Show(Properties.Resources.INVALID_LOGIN_CREDENTIALS, "Error");
            } else
            {
                checkIfUserValid(emailTXT, passwordTXT);
            }

        }

        private void checkIfUserValid(String email, String password)
        {
            //referrence from https://stackoverflow.com/questions/27730546/how-to-define-datadirectory-for-connectionstring-in-console-application-to-work

            string relative = @"C:\Users\Adam Ameen\Documents\ExpenseGuideDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ExpenseGuideDB.mdf;Integrated Security=True"))
                {
                    //referrenced from https://www.aspsnippets.com/Articles/Retrieve-data-from-Database-in-Windows-Forms-Application-using-C-and-VBNet.aspx

                    con.Open();
                    string query = "SELECT * FROM Credentials WHERE Email = '" + email + "' AND Password = '" + password + "'  ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    con.Close();
                    if (dta.Rows.Count == 1)
                    {
                        getLoggedInUserDetails(email, password);
                        FormDashboard formDashboard = new FormDashboard();
                        formDashboard.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show(Properties.Resources.INVALID_LOGIN_CREDENTIALS,"Invalid Credentials");
                    }
                }
            } catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void getLoggedInUserDetails(String email, String password)
        {
            string relative = @"C:\Users\Adam Ameen\Documents\ExpenseGuideDB.mdf";
            string absolute = Path.GetDirectoryName(relative);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);


            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ExpenseGuideDB.mdf;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT * FROM Credentials WHERE Email = '" + email + "' AND Password = '" + password + "'  ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                con.Close();
                if (dta.Rows.Count == 1)
                {
                    globalLoggedInUserName = dta.Rows[0]["UserName"].ToString();
                    globalLoggedInUserID = Int32.Parse(dta.Rows[0]["User_Id"].ToString());
                }
            }
        }
    }
}
