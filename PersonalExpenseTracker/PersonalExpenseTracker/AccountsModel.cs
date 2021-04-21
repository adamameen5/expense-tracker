using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public class AccountsModel
    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
