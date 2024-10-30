using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.customerController
{
    public static class CustomerController
    {
        public static Customer InsertIntoCustomer(Customer customer)
        {
            Console.Write($"Enter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write($"Enter Your Age: ");
            customer.Age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Your Email: ");
            customer.Email = Console.ReadLine();
            customer.CustomerStatus = CustomerStatus.Active;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Account Created Successfully!\n-------------------------");
            
            return customer;
        }
    }
}