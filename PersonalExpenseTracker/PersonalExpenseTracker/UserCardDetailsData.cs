using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    /*
     * This is the Entity class for Card Detais
     */
    public class UserCardDetailsData
    {
        public String cardNumber { get; set; }
        public String cardDateOfExpiry { get; set; }
        public String cardBankName { get; set; }
        public String cardNameToDisplay { get; set; }
    }
}
