using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    public class UserModel
    {
        public void saveUserInformation(UserCredentialsData info)
        {
            //apply business rules
            //throw exceptions
            //push to database
            //using the entity framework


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



        }
    }
}
