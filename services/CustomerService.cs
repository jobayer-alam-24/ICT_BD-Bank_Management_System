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
                return; 
            }
            throw new ArgumentNullException("You can not Insert Epty Values!");
        }
        public static Customer GetCustomer(int customerId)
        {
            Customer GetCustomerByID = FoundCustomer(CheckID(customerId));
            if(GetCustomerByID != null)
            {
                return GetCustomerByID;
            }
            throw new ArgumentNullException("Customer Not Found!");
        }
        public static string UpdateCustomer(int id, Customer customer)
        {
            Customer GetExistingCustomerByID = FoundCustomer(CheckID(id));
            if(GetExistingCustomerByID != null)
            {
                _CONTEXT.Customers.Remove(GetExistingCustomerByID);
                _CONTEXT.SaveChanges();
                
                GetExistingCustomerByID.Name = customer.Name;
                GetExistingCustomerByID.Age = customer.Age;
                GetExistingCustomerByID.Email = customer.Email;
                GetExistingCustomerByID.PhoneNumber =  customer.PhoneNumber;             
                GetExistingCustomerByID.Address = customer.Address;                
                GetExistingCustomerByID.CustomerStatus = customer.CustomerStatus;

                _CONTEXT.Customers.Update(customer);
                _CONTEXT.SaveChanges();

            }
            throw new ArgumentNullException("Vacant Customer!");
        }
        public static string RemoveCustomer(int id)
        {
            Customer GetCustomerByID = FoundCustomer(CheckID(id));
            if(GetCustomerByID != null)
            {
                _CONTEXT.Customers.Remove(GetCustomerByID);
                _CONTEXT.SaveChanges();
                return "-------------------\nMessege: Customer Deleted Successfully!\n-------------";
            }
            throw new ArgumentNullException("Customer Not Found!");
        }
        private static Customer FoundCustomer(int ID)
        {
            return _CONTEXT.Customers.FirstOrDefault(objects => objects.ID == ID);
        }
        private static int CheckID(int id)
        {
            if(id <= 0) return 0;
            return id; 
        }
    }
}