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
    }
}
