using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.services
{
    public static class CustomerService
    {
        private static BankManagementSystemDBContext _CONTEXT;
        static CustomerService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }

        public static void AddCustomer(Customer customer)
        {
            if(customer != null)
            {
                _CONTEXT.Customers.Add(customer);
                _CONTEXT.SaveChanges();
            }
        }
    }
}