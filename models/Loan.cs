using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;
namespace ICT_BD_Bank_Management_System.models
{
    public class Loan
    {
        public int ID { get; set; }
        public LoanTypes LoanTypes { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public int Term {get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt {get; set; }
        public LoanStatus LoanStatus { get; set; }
    }
}