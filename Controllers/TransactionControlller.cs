
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.transactionController
{
    public static class TransactionController
    {
        public static Transaction CreateA_Transaction(int id, Transaction transaction)
        {
            Console.Write($"Enter Your Transaction Amount: ");
            transaction.Amount = Convert.ToDecimal(Console.ReadLine());
            transaction.Date = DateTime.Now;
            transaction.AccountId = id;
            transaction.TransactionTypes = TransactionTypes.Deposit;
            Console.WriteLine($"-------------------------\nMessege: Transaction Created Successfully!\n-------------------------");
            
            return transaction;
        }
        public static Transaction UpdateTransaction(Account account, Transaction transaction)
        {
            Console.WriteLine($"-------------Updating Transaction------------");
            Console.Write($"Enter Your Transaction Amount: ");
            transaction.Amount = Convert.ToDecimal(Console.ReadLine());
            transaction.Date = DateTime.Now;
            transaction.AccountId = account.ID;
            transaction.TransactionTypes = TransactionTypes.Deposit;
            
            return transaction;
        }
        public static void PrintTransactionDetailsByID(Transaction transaction)
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Found Transaction Info: {transaction.ID}");
            Console.WriteLine($"Account ID: {transaction.AccountId}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Amount: {transaction.Amount}$");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Transaction Type: {transaction.TransactionTypes}");
        }
    }
}

