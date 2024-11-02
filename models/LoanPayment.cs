using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT_BD_Bank_Management_System.models
{
    public class LoanPayment
    {
        public int Id { get; set;}
        public DateTime PaidDate { get; set; }
        public decimal PaidAmount { get; set; }
        //Relation with Loan
        public int LoanID { get; set; }
    }
}