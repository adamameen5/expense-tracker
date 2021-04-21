using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{

    /*
     * This is the Entity class for transaction details
     */

    public class UserTransactionsData
    {
        public String transactionDate { get; set; }
        public String transactionContactName { get; set; }
        public String transactionAmount { get; set; }
        public String transactionEvent { get; set; }
        public String transactionAssociatedAccount { get; set; }
        public String transactionType { get; set; }
        public String transactionCode { get; set; }

    }
}
