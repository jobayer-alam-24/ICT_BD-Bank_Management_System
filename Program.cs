using ICT_BD_Bank_Management_System.models;
using ICT_BD_Bank_Management_System.services;
using ICT_BD_Bank_Management_System.customerController;
using ICT_BD_Bank_Management_System.transactionController;
using System.Diagnostics;
using ICT_BD_Bank_Management_System.accountController;
using ICT_BD_Bank_Management_System.enums;
namespace ICT_BD_Bank_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer rahman = new Customer{
                    Name = "Rahman Khan",
                    Age = 23,
                    Email = "rahman@gmail.com",
                    PhoneNumber = "01903081186",
                    Address = "Dhaka Mirpur 10",
                    CustomerStatus = CustomerStatus.Active
                };
                Loan rahmansLoan = new Loan{
                    ID =  1,
                    LoanTypes = LoanTypes.Monthly,
                    LoanStatus = LoanStatus.Active,
                    Amount = 50000,
                    LoanAmount = 5000,
                    DuePayment = 5000,
                    InterestRate = 0.5m,
                    Term = 12,
                    StartedAt = DateTime.Now,
                    EndedAt = DateTime.MinValue,
                    PrincipalAmount = 50000,
                    InterestAmount = 50000 * 0.5m, 
                    CustomerID = 1
                };
                LoanPayment loanPaymentOfRahman = new LoanPayment{
                    PaidDate = DateTime.Now,
                    PaidAmount = 600, 
                    LoanID = 1
                };
                Customer rahmanUpdated = new Customer();
                Account rahmansAccount = new Account();
                Account rahmansAccount2 = new Account();
                Transaction deposit = new Transaction();
                Transaction withdraw = new Transaction();
                Loan loan1 = new Loan();
                Console.WriteLine($"~~~~~~~~----------------Bank Management System----------------~~~~~~~~");
                //********************************************************************************************Account******************************************************************
                // AccountService.AddAccount(AccountController.CreateA_Account(rahmansAccount));
                // AccountController.PrintSpecificAccountDetailsByID(AccountService.FoundAccountById(2));
                // Console.WriteLine(AccountService.UpdateAccount(10, AccountController.UpdateAccount(rahmansAccount2)));
                // AccountController.PrintSpecificAccountDetailsByID(AccountService.FoundAccountById(10));
                // Console.WriteLine(AccountService.RemoveAccount(4));

                //********************************************************************************************Customer********************************************************************
                // CustomerService.AddCustomer(rahman);
                // CustomerService.AddCustomer(CustomerController.InsertIntoCustomer(rahman));
                // CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                // Console.WriteLine(CustomerService.UpdateCustomer(10, CustomerController.UpdateIntoCustomer(rahmanUpdated)));
                // CustomerController.PrintSpecificCustomerByID(CustomerService.GetCustomer(10));
                // Console.WriteLine(CustomerService.RemoveCustomer(4));

                //*******************************************************************************************Transaction********************************************************************
                //Deposit
                // Transaction transaction1 = TransactionController.CreateA_Transaction(deposit);
                // TransactionHistoryService.AddTransaction(transaction1);
                // AccountController.PrintSpecificAccountDetailsByID(AccountService.FoundAccountById(2));
                // TransactionController.PrintTransactionDetailsByID(TransactionHistoryService.GetTransaction(2));
                // TransactionHistoryService.UpdateTransaction(2, TransactionController.UpdateTransaction(rahmansAccount, transaction1));
                // TransactionController.PrintTransactionDetailsByID(TransactionHistoryService.GetTransaction(2));
                // Console.WriteLine(TransactionHistoryService.RemoveTransaction(3));
                //*******************************************************************************************Loan********************************************************************
                // LoanController.PrintLoanPaymentDetailsOf(rahmansLoan);
                // LoanService.AddLoanPayment(loanPaymentOfRahman);
                // LoanController.PrintLoanDetailsWhoTookLoan(4, rahmansLoan);
                // LoanService.AddLoan(rahmansLoan);
                // LoanService.UpdateLoanPayment(loanPaymentOfRahman);
                // LoanService.AddLoan(LoanController.CreateA_Loan(loan1));
                // LoanController.PrintSpecificLoanDetailsByID(LoanService.GetLoan(4));
                // LoanService.UpdateLoan(2, LoanController.UpdateLoan(loan1));
                // LoanController.PrintSpecificLoanDetailsByID(LoanService.GetLoan(2));
                // Console.WriteLine(LoanService.RemoveLoan(1));  
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine($"Error: {e.ParamName}");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine($"Error: {e}");
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