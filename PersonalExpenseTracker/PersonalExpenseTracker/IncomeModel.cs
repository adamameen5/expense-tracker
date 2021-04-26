using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    class IncomeModel
    {
        int userId = FormLogin.globalLoggedInUserID;

        public String GetTransactionCode()
        {
            String code = "";
            using (var context = new ExpenseGuideDBContainer())
            {
                var countOfIds = context.Transactions.Count(y => y.UserId == userId && y.TransactionType == "Income");
                code = "U" + userId + "-INC-" + (countOfIds + 1);
                return code;
            }
        }


        public List<String> GetListOfPayor()
        {
            List<String> payorNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var listOfPayor = context.Contacts.Where(x => x.UserId == userId && x.ContactType == "Payor").ToList();
                foreach (var item in listOfPayor)
                {
                    payorNameList.Add(item.ContactName);
                }
                return payorNameList;
            }
        }


        public List<String> GetListOfEvents()
        {
            List<String> eventNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var listOfPayor = context.Events.Where(x => x.UserId == userId && x.EventCategory == "Income").ToList();
                foreach (var item in listOfPayor)
                {
                    eventNameList.Add(item.EventName);
                }
                return eventNameList;
            }
        }


        public List<String> GetListOfAccounts()
        {
            List<String> accountsNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var listOfAccounts = context.BankAccountDetails.Where(x => x.UserId == userId).ToList();
                foreach (var item in listOfAccounts)
                {
                    accountsNameList.Add(item.BankAccountNameToDisplay);
                }
                return accountsNameList;
            }
        }


        public int GetContactID(String contactName)
        {
            using (var context = new ExpenseGuideDBContainer())
            {
                var contact = context.Contacts.Where(x => x.UserId == userId && x.ContactName == contactName).FirstOrDefault();
                return contact.Id;
            }
        }


        public Boolean SaveIncomeInfo(int contactID, UserTransactionsData info)
        {
            try
            {
                Transaction transactionRecord = new Transaction();
                transactionRecord.TransactionDate = info.transactionDate;
                transactionRecord.TransactionContactName = info.transactionContactName;
                transactionRecord.TransactionAmount = info.transactionAmount;
                transactionRecord.TransactionEvent = info.transactionEvent;
                transactionRecord.TransactionAssociatedAccount = info.transactionAssociatedAccount;
                transactionRecord.TransactionType = info.transactionType;
                transactionRecord.TransactionCode = info.transactionCode;
                transactionRecord.UserId = userId;
                transactionRecord.ContactId = contactID;

                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.Transactions.Add(transactionRecord);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Boolean UpdateIncomeInfo(int id, UserTransactionsData info)
        {
            try
            {
                Transaction transactionRecord = new Transaction();

                transactionRecord.TransactionDate = info.transactionDate;
                transactionRecord.TransactionContactName = info.transactionContactName;
                transactionRecord.TransactionAmount = info.transactionAmount;
                transactionRecord.TransactionEvent = info.transactionEvent;
                transactionRecord.TransactionAssociatedAccount = info.transactionAssociatedAccount;
                transactionRecord.TransactionType = info.transactionType;
                transactionRecord.TransactionCode = info.transactionCode;

                // Update to database
                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();

                using (var context = new ExpenseGuideDBContainer())
                {
                    var std = context.Transactions.Find(id);
                    std.TransactionDate = info.transactionDate;
                    std.TransactionContactName = info.transactionContactName;
                    std.TransactionAmount = info.transactionAmount;
                    std.TransactionEvent = info.transactionEvent;
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        public Task SaveIncomeInfoAsync(int contactID, UserTransactionsData info)
        {
            return Task.Run(() => SaveIncomeInfo(contactID, info));
        }
    }
}
