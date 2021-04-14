using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormSignUp : Form
    {
        public UserDetails userDetailsData { get; set; }

        public FormSignUp()
        {
            InitializeComponent();
            this.RestoreData();
        }

        private void validateUserInfo(object sender, EventArgs e)
        {
            this.userDetailsData = new UserDetails();
            this.userDetailsData.userName = this.userName.Text;
            this.userDetailsData.email = this.email.Text;
            this.userDetailsData.nicNumber = this.nicNumber.Text;
            this.userDetailsData.password = this.password.Text;

            try
            {
                String myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                FileStream file = new FileStream(myDocs + "\\SignUpDetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(file,Encoding.Unicode);

                String serializedObject = JsonConvert.SerializeObject(this.userDetailsData, Formatting.Indented);
                sw.Write(serializedObject);

                //sw.WriteLine(this.userDetailsData.userName);
                //sw.WriteLine(this.userDetailsData.email);
                //sw.WriteLine(this.userDetailsData.nicNumber);
                //sw.WriteLine(this.userDetailsData.password);

                sw.Close();
                file.Close();
                this.Close();

            } catch (Exception ex)
            {
                Console.WriteLine("Error while writing");
            }
            
        }

        private void RestoreData()
        {
            String s1 = "";
            String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FileStream file = new FileStream(myDocument + "\\SignUpDetails.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(file, Encoding.Unicode);

            if (sr.EndOfStream == false)
            {
                s1 = sr.ReadToEnd();
            }

            sr.Close();
            file.Close();

            if (s1 != "")
            {
                UserDetails ud = JsonConvert.DeserializeObject<UserDetails>(s1);
                this.userName.Text = ud.userName;
                this.email.Text = ud.email;
                this.nicNumber.Text = ud.nicNumber;
                this.password.Text = ud.password;
                this.confirmPassword.Text = ud.password;
            }
        }
    }
}
