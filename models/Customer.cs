using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;

namespace ICT_BD_Bank_Management_System.models
{
    public class Customer
    {
        public int ID { get; set; }
        public CustomerStatus CustomerStatus { get; set; }
    }
}