
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.accountController
{
    public static class AccountController
    {
        public static Account CreateA_Account(int CustomerID, Account account)
        {
            Console.Write($"Enter Your Account Number: ");
            account.Number = Console.ReadLine();
            Console.Write($"Enter Your Balance: ");
            account.Balance = int.Parse(Console.ReadLine());
            account.OpenedAt = DateTime.Now;
            account.ClosedAt = new DateTime();
            account.AccountTypes = AccountTypes.Savings;
            account.AccountStatus = AccountStatus.Active;
            account.CustomerID = CustomerID;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Account Created Successfully!\n-------------------------");
            
            return account;
        }
        public static Account UpdateAccount(int CustomerID, Account account)
        {
            Console.WriteLine($"-------------Updating Account------------");
            Console.Write($"Enter Your Account Number: ");
            account.Number = Console.ReadLine();
            Console.Write($"Enter Your Balance: ");
            account.Balance = int.Parse(Console.ReadLine());
            account.OpenedAt = DateTime.Now.AddHours(-5);
            account.ClosedAt = DateTime.Now;
            account.CustomerID = CustomerID;
            account.AccountTypes = AccountTypes.Student;
            account.AccountStatus = AccountStatus.Deleted;
            
            return account;
        }
        public static void PrintSpecificAccountDetailsByID(Account account)
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Found Account Info: {account.ID}");
            string isNullPrintAnother = account.CustomerID == 0 ? "Not Provided" : $"{account.CustomerID}";
            Console.WriteLine($"Customer ID: {isNullPrintAnother}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Number: {account.Number}");
            Console.WriteLine($"Balance: {account.Balance}$");
            Console.WriteLine($"Opened Date: {account.OpenedAt}");
            string printOnCon = account.ClosedAt != new DateTime() ? "Closed Date: " + DateTime.Now.ToString() : $"Account is {account.AccountStatus}";
            Console.WriteLine(printOnCon);
            Console.WriteLine($"Account Status: {account.AccountStatus}");
            Console.WriteLine($"Account Types: {account.AccountTypes}");
        }
    }
}

