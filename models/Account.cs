using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;

namespace ICT_BD_Bank_Management_System.models
{
    public class Account
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public DateTime  OpenedAt { get; set; }
        public DateTime  ClosedAt { get; set; }
        public AccountTypes AccountTypes { get; set; }
        public AccountStatus AccountStatus { get; set; }

        //Relationship with Customer USING FK
        public int CustomerID { get; set; }
    }
}