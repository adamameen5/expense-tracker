//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalExpenseTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string TransactionContactName { get; set; }
        public string TransactionAmount { get; set; }
        public string TransactionEvent { get; set; }
        public string TransactionAssociatedAccount { get; set; }
        public string TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public int UserId { get; set; }
        public Nullable<int> ContactId { get; set; }
    }
}
