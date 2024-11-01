using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.services
{
    public static class TransactionService
    {
        private static BankManagementSystemDBContext _CONTEXT;
        static TransactionService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }
        public static void AddTransaction(Transaction transaction)
        {
            if(transaction != null)
            {
                _CONTEXT.Transactions.Add(transaction);
                _CONTEXT.SaveChanges();
            }
            else throw new ArgumentNullException("Null Transaction Can not Possible to Add.");
        }
        public static string RemoveTransaction(int id)
        {
            Transaction GetExistingTransaction = GetTransaction(id);
            if(GetExistingTransaction != null)
            {
                _CONTEXT.Transactions.Remove(GetExistingTransaction);
                _CONTEXT.SaveChanges();
                return "Messege: Transaction Removed Successfully!";
            }
            else throw new ArgumentNullException("Vacant Transaction Can not possible to Remove.");
        } 
        public static string UpdateTransaction(int id, Transaction transaction) 
        {
            Transaction GetExistingTransaction = GetTransaction(id);
            if(GetExistingTransaction != null)
            {
                GetExistingTransaction.TransactionTypes = transaction.TransactionTypes;
                GetExistingTransaction.Amount = transaction.Amount;
                GetExistingTransaction.Date = transaction.Date;
                _CONTEXT.SaveChanges();
                return "Messege: Transaction Updated Successfully!";
            } 
            else throw new ArgumentNullException("Vacant Transaction Can not possible to Update!");
        }
        public static Transaction GetTransaction(int id)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID In Transaction");
            else return _CONTEXT.Transactions.FirstOrDefault(x => x.ID == id);
        }
    }
}