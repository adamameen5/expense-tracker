using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public class ContactsModel
    {
        public Boolean addContactRecord(int cardBelongingToId, UserContactsData info) 
        {
            try
            {
                Contact contactRecord = new Contact();
                contactRecord.ContactName = info.contactName;
                contactRecord.ContactDescription = info.contactDescription;
                contactRecord.ContactType = info.contactType;
                contactRecord.ContactTelephoneNumber = info.contactTelephoneNumber;
                contactRecord.UserId = cardBelongingToId;

                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.Contacts.Add(contactRecord);
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
