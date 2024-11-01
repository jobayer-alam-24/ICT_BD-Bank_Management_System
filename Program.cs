﻿using ICT_BD_Bank_Management_System.models;
using ICT_BD_Bank_Management_System.services;
using ICT_BD_Bank_Management_System.customerController;
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
                Account rahmansAccount = new Account();
                Account rahmansAccount2 = new Account();
                Console.WriteLine($"~~~~~~~~----------------Bank Management System----------------~~~~~~~~");
                //********************************************************************************************Account******************************************************************
                // AccountService.AddAccount(AccountController.CreateA_Account(rahmansAccount));
                // AccountController.PrintSpecificAccountDetailsByID(AccountService.FoundAccountById(10));
                // Console.WriteLine(AccountService.UpdateAccount(10, AccountController.UpdateAccount(rahmansAccount2)));
                // AccountController.PrintSpecificAccountDetailsByID(AccountService.FoundAccountById(10));
                // Console.WriteLine(AccountService.RemoveAccount(4));

                //********************************************************************************************Customer********************************************************************
                // CustomerService.AddCustomer(CustomerController.InsertIntoCustomer(rahman));
                // CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                // Console.WriteLine(CustomerService.UpdateCustomer(10, CustomerController.UpdateIntoCustomer(rahmanUpdated)));
                // CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                // Console.WriteLine(CustomerService.RemoveCustomer(4));
            
                
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine($"Error: {e.ParamName}");
            }
            catch(ArgumentException e)
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