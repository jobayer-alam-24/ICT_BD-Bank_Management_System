using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;
namespace ICT_BD_Bank_Management_System.models
{
    public class Transaction
    {
        public int ID { get; set; }
        public TransactionTypes TransactionTypes { get; set; }
        public decimal Amount { get; set; } 
        public DateTime Date {get; set; }

        public int AccountId { get; set; }
    }
}