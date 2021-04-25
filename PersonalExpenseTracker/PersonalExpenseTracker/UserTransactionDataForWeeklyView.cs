using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    public class UserTransactionDataForWeeklyView
    {
        public DateTime transactionDate { get; set; }
        public String transactionContactName { get; set; }
        public String transactionAmount { get; set; }
        public String transactionEvent { get; set; }
        public String transactionAssociatedAccount { get; set; }
        public String transactionType { get; set; }
        public String transactionCode { get; set; }

        public UserTransactionDataForWeeklyView(DateTime transDate, String transcontname, String transamount, String transEvent, String transAccount, String transtype, String transcode)
        {
            this.transactionDate = transDate;
            this.transactionContactName = transcontname;
            this.transactionAmount = transamount;
            this.transactionEvent = transEvent;
            this.transactionAssociatedAccount = transAccount;
            this.transactionType = transtype;
            this.transactionCode = transcode;

        }
    }
}
