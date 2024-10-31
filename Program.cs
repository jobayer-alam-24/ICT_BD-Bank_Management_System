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
                Customer rahman = new Customer();
                Customer rahmanUpdated = new Customer();
                Console.WriteLine($"~~~~~~~~----------------Bank Management System----------------~~~~~~~~");
                CustomerService.AddCustomer(CustomerController.InsertIntoCustomer(rahman));
                CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                Console.WriteLine(CustomerService.UpdateCustomer(10, CustomerController.UpdateIntoCustomer(rahmanUpdated)));
                CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                Console.WriteLine(CustomerService.RemoveCustomer(4));
            
                
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine($"Error: {e.ParamName}");
            }
            catch(FormatException)
            {
                Console.WriteLine($"Error: Invalid Format!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}