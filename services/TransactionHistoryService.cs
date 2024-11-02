using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.services
{
    public static class TransactionHistoryService
    {
        private static BankManagementSystemDBContext _CONTEXT;
        static TransactionHistoryService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }
        public static void AddTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                if (TransactionTypes.Deposit == transaction.TransactionTypes)
                {
                    bool IsDeposited = TransactionService.Deposit(transaction.AccountId, transaction.Amount);
                    if (IsDeposited)
                    {
                        _CONTEXT.Transactions.Add(transaction);
                        _CONTEXT.SaveChanges();
                        Console.WriteLine($"Messege: Transaction Inserted Successfully!");
                    }
                    else throw new ArgumentException("Something Went Wrong! Please contact with the Bank");
                }
                if(TransactionTypes.Withdraw == transaction.TransactionTypes)
                {
                    bool IsWithDrawed = TransactionService.Withdraw(transaction.AccountId, transaction.Amount); 
                    if(IsWithDrawed)
                    {
                        _CONTEXT.Transactions.Add(transaction);
                        _CONTEXT.SaveChanges();
                        Console.WriteLine($"Messege: Withdrawn Successfully!");
                    }
                    else throw new ArgumentException("Something Went Wrong! Please contact with the Bank");
                }
            }
            else throw new ArgumentNullException("Null Transaction Can not Possible to Add.");
        }
        public static string RemoveTransaction(int id)
        {
            Transaction GetExistingTransaction = GetTransaction(id);
            if (GetExistingTransaction != null)
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
            if (GetExistingTransaction != null)
            {
                GetExistingTransaction.TransactionTypes = transaction.TransactionTypes;
                GetExistingTransaction.Amount = transaction.Amount;
                GetExistingTransaction.AccountId = transaction.AccountId;
                GetExistingTransaction.Date = transaction.Date;
                _CONTEXT.SaveChanges();
                return "Messege: Transaction Updated Successfully!";
            }
            else throw new ArgumentNullException("Vacant Transaction Can not possible to Update!");
        }
        public static Transaction GetTransaction(int id)
        {
            if (id <= 0) throw new ArgumentException("Invalid ID In Transaction");
            else return _CONTEXT.Transactions.FirstOrDefault(x => x.ID == id);
        }
    }
}