
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.transactionController
{
    public static class TransactionController
    {
        public static Transaction CreateA_Transaction(Transaction transaction)
        {
            Console.Write($"Enter Your Transaction Amount: ");
            transaction.Amount = Convert.ToDecimal(Console.ReadLine());
            transaction.Date = DateTime.Now;
            transaction.TransactionTypes = TransactionTypes.Withdraw;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Transaction Created Successfully!\n-------------------------");
            
            return transaction;
        }
        public static Transaction UpdateTransaction(Transaction transaction)
        {
            Console.WriteLine($"-------------Updating Transaction------------");
            Console.Write($"Enter Your Transaction Amount: ");
            transaction.Amount = Convert.ToDecimal(Console.ReadLine());
            transaction.Date = DateTime.Now;
            transaction.TransactionTypes = TransactionTypes.Deposit;
            
            return transaction;
        }
        public static void PrintTransactionDetailsByID(Transaction transaction)
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Found Transaction Info: {transaction.ID}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Amount: {transaction.Amount}$");
            Console.WriteLine($"Date: {transaction.Date}");
            Console.WriteLine($"Transaction Type: {transaction.TransactionTypes}");
        }
    }
}

