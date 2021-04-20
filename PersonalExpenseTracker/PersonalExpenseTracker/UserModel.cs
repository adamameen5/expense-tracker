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

        public Boolean saveCardDetails(int cardBelongingToId, UserCardDetailsData info)
        {
            try
            {
                CardDetail cardDetails = new CardDetail();
                cardDetails.CardBankName = info.cardBankName;
                cardDetails.CardDateOfExpiry = info.cardDateOfExpiry;
                cardDetails.CardNameToDisplay = info.cardNameToDisplay;
                cardDetails.CardNumber = info.cardNumber;
                cardDetails.UserId = cardBelongingToId;

                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.CardDetails.Add(cardDetails);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
           
        }

        public Boolean saveBankAccountDetails(int accountBelongingToId, UserBankAccountDetailsData info)
        {
            try
            {
                BankAccountDetail bankAccountDetails = new BankAccountDetail();
                bankAccountDetails.BankAccountBankName = info.bankAccountBankName;
                bankAccountDetails.BankAccountNumber = info.bankAccountNumber;
                bankAccountDetails.BankAccountBranchName = info.bankAccountBranchName;
                bankAccountDetails.BankAccountNameToDisplay = info.bankAccountNameToDisplay;
                bankAccountDetails.UserId = accountBelongingToId;

                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.BankAccountDetails.Add(bankAccountDetails);
                db.SaveChanges();

                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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
