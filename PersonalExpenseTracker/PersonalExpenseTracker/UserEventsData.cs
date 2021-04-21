using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    /*
     * This is the Entity class for Event details
     */
    public class UserEventsData
    {
        public String eventDate { get; set; }
        public String eventCode { get; set; }
        public String eventName { get; set; }
        public String eventRecurring { get; set; }
        public String eventType { get; set; }
        public String eventCategory { get; set; }
        public String eventAssociateContact { get; set; }
    }
}
