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
        public Boolean addPayeeRecord(int cardBelongingToId, UserContactsData info) 
        {
            try
            {
                Contact conactRecord = new Contact();
                conactRecord.ContactName = info.contactName;
                conactRecord.ContactDescription = info.contactDescription;
                conactRecord.ContactType = info.contactType;
                conactRecord.ContactTelephoneNumber = info.contactTelephoneNumber;
                conactRecord.UserId = cardBelongingToId;

                ExpenseGuideDBContainer db = new ExpenseGuideDBContainer();
                db.Contacts.Add(conactRecord);
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
