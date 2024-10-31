using ICT_BD_Bank_Management_System.customerController;
using ICT_BD_Bank_Management_System.models;
using ICT_BD_Bank_Management_System.services;

namespace ICT_BD_Bank_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer rahim = new Customer();
                Console.WriteLine($"~~~~~~~~----------------Bank Management System----------------~~~~~~~~");
                CustomerService.AddCustomer(CustomerController.InsertIntoCustomer(rahim));
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}