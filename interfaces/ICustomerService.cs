using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        // void RemoveCustomer(int id);
        // void UpdateCustomer(int id, Customer customer);
        // Customer GetCustomer(int id);
    }
}