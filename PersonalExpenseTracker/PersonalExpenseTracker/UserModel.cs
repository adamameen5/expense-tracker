using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public class UserModel
    {
        public int saveUserInformation(UserCredentialsData info)
        {
            //apply business rules
            //throw exceptions
            //push to database
            //using the entity framework

            try
            {
                Credentials userCredentials = new Credentials();
                User userInfo = new User();

                userCredentials.UserName = info.userName;
                userCredentials.Email = info.email;
                userCredentials.Password = info.password;
                userCredentials.NIC = info.nicNumber;

                userInfo.FullName = info.userName;

                //1-to-1 relationships

                userCredentials.User = new User();
                userCredentials.User = userInfo;


                //adding to database
                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.Credentials.Add(userCredentials);
                db.Users.Add(userInfo);
                db.SaveChanges();

                int User_ID = userInfo.Id;

                return User_ID;
            } 
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void updateUserInformation(int idToUpdate, UserDetails info)
        {
            try
            {
                using (var context = new ExpenseGuideDBContainer())
                {
                    var std = context.Users.Find(idToUpdate);
                    std.FullName = info.fullName;
                    std.Contact = info.contact;
                    std.RecoveryEmailAddress = info.recoveryEmailAddress;
                    std.DateOfBirth = info.dateOfBirth;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
