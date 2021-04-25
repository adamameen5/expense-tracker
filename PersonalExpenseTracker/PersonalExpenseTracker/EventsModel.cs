using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public class EventsModel
    {
        int userId = FormLogin.globalLoggedInUserID;

        public Boolean addEventRecord(int eventBelongingToId, UserEventsData info)
        {
            try
            {
                Event eventRecord = new Event();
                eventRecord.EventDate = info.eventDate;
                eventRecord.EventCode = info.eventCode;
                eventRecord.EventName = info.eventName;
                eventRecord.EventRecurring = info.eventRecurring;
                eventRecord.EventType = info.eventType;
                eventRecord.EventCategory = info.eventCategory;
                eventRecord.EventAssociatedContact = info.eventAssociateContact;
                eventRecord.UserId = eventBelongingToId;


                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.Events.Add(eventRecord);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public String GetEventCode()
        {
            String code = "";
            using (var context = new ExpenseGuideDBContainer())
            {
                var countOfIds = context.Events.Count(y => y.UserId == userId);
                code = "U" + userId + "-EVENT-" + (countOfIds + 1);
                return code;
            }
        }


        public List<String> GetListOfContacts(String typeOfContact)
        {
            List<String> contactNameList = new List<String>();

            using (var context = new ExpenseGuideDBContainer())
            {
                if (typeOfContact != "All")
                {
                    var listOfPayee = context.Contacts.Where(x => x.UserId == userId && x.ContactType == typeOfContact).ToList();
                    foreach (var item in listOfPayee)
                    {
                        contactNameList.Add(item.ContactName);
                    }
                    return contactNameList;
                } else
                {
                    var listOfPayee = context.Contacts.Where(x => x.UserId == userId).ToList();
                    foreach (var item in listOfPayee)
                    {
                        contactNameList.Add(item.ContactName);
                    }
                    return contactNameList;
                }
                
            }
        }


        public List<UserTransactionDataForWeeklyView> GetListOfTransactions(DateTime selectedDate)
        {
            List<UserTransactionDataForWeeklyView> expensesListForWeeklyView = new List<UserTransactionDataForWeeklyView>();

            using (var context = new ExpenseGuideDBContainer())
            {
                var x = context.Transactions.Where(t => t.UserId == userId && (t.TransactionDate.Value.Year == selectedDate.Year && t.TransactionDate.Value.Month == selectedDate.Month && t.TransactionDate.Value.Day == selectedDate.Day)).ToList();

                foreach (var item in x)
                {
                    expensesListForWeeklyView.Add(new UserTransactionDataForWeeklyView(item.TransactionDate.Value, item.TransactionContactName, item.TransactionAmount, item.TransactionEvent, item.TransactionAssociatedAccount, item.TransactionType, item.TransactionCode));
                }

                return expensesListForWeeklyView;
            }
        }
    }
}
