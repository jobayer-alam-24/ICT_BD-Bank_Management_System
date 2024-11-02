using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;
using ICT_BD_Bank_Management_System.services;

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
            Console.Write($"Enter Your Phone Number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.Write($"Enter Your Address: ");
            customer.Address = Console.ReadLine();
            customer.CustomerStatus = CustomerStatus.Active;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Account Created Successfully!\n-------------------------");
            
            return customer;
        }
        public static Customer UpdateIntoCustomer(Customer customer)
        {
            Console.WriteLine($"-------------Updating Customer------------");
            Console.Write($"Enter Your Name: ");
            customer.Name = Console.ReadLine();
            Console.Write($"Enter Your Age: ");
            customer.Age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Your Email: ");
            customer.Email = Console.ReadLine();
            Console.Write($"Enter Your Phone Number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.Write($"Enter Your Address: ");
            customer.Address = Console.ReadLine();
            customer.CustomerStatus = CustomerStatus.Deleted;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Customer Updated Successfully!\n-------------------------");
            
            return customer;
        }
        public static void PrintSpecificCustomerByID(Customer customer)
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Found Customer: {customer.ID}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Phone Number: {customer.PhoneNumber}");
            Console.WriteLine($"Address: {customer.Address}");
            Console.WriteLine($"Customer Status: {customer.CustomerStatus}");
        }
    }
}