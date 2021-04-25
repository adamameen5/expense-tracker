using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    class ExpenseModel
    {
        
        int userId = FormLogin.globalLoggedInUserID;

        
        public String GetTransactionCode()
        {
            String code = "";
            using (var context = new ExpenseGuideDBContainer())
            {
                var countOfIds = context.Transactions.Count(y => y.UserId == userId && y.TransactionType == "Expense");
                code = "U" + userId + "-EXP-" + (countOfIds + 1);
                return code;
            }
        }


        public List<UserTransactionDataForWeeklyView> GetListOfTransactions(DateTime selectedDate)
        {
            List<UserTransactionDataForWeeklyView> expensesListForWeeklyView = new List<UserTransactionDataForWeeklyView>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var x= context.Transactions.Where(t => t.UserId == userId && (t.TransactionDate.Value.Year == selectedDate.Year && t.TransactionDate.Value.Month == selectedDate.Month && t.TransactionDate.Value.Day == selectedDate.Day)).ToList();

                foreach (var item in x)
                {
                    expensesListForWeeklyView.Add(new UserTransactionDataForWeeklyView(item.TransactionDate.Value,item.TransactionContactName,item.TransactionAmount,item.TransactionEvent,item.TransactionAssociatedAccount, item.TransactionType,item.TransactionCode));
                }               

                return expensesListForWeeklyView;
            }
        }


        public List<String> GetListOfPayee()
        {
            List<String> payeeNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var listOfPayee = context.Contacts.Where(x => x.UserId == userId && x.ContactType == "Payee").ToList();
                foreach (var item in listOfPayee)
                {
                    payeeNameList.Add(item.ContactName);
                }
                return payeeNameList;
            }
        }


        public List<String> GetListOfEvents()
        {
            List<String> eventNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var listOfPayee = context.Events.Where(x => x.UserId == userId && x.EventCategory == "Expense").ToList();
                foreach (var item in listOfPayee)
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


        public Boolean SaveExpenseInfo(int contactID, UserTransactionsData info)
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


        public Boolean UpdateExpenseInfo(int id, UserTransactionsData info)
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
    }
}
