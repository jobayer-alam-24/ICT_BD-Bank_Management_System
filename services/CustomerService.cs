using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.interfaces;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.services
{
    public class CustomerService : ICustomerService
    {
        private BankManagementSystemDBContext _CONTEXT;
        public CustomerService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }

        public void AddCustomer(Customer customer)
        {
            if(customer != null)
            {
                _CONTEXT.Customers.Add(customer);
                _CONTEXT.SaveChanges();
            }
        }
    }
}