using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
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
        public static bool Deposit(int AccountID, decimal DepositAmount)
        {
            if(DepositAmount <= 0 || AccountID <= 0) return false;
            else
            {
                Account GetAccountByID = AccountService.FoundAccountById(AccountID);
                if(GetAccountByID == null) return false;
                else
                {
                    if(DepositAmount > 100000) throw new ArgumentException("You can not Deposit Up to 100000 at a Time!");
                    else GetAccountByID.Balance += DepositAmount;
                }
                _CONTEXT.Accounts.Update(GetAccountByID);
                _CONTEXT.SaveChanges();
                return true;
            }
        }
        public static bool Withdraw(int AccountID, decimal WithdrawAmount)
        {
            if(AccountID <= 0 || WithdrawAmount <= 0) return false;
            else
            {
                Account GetAccount = AccountService.FoundAccountById(AccountID);
                if(GetAccount == null) return false;
                else
                {
                    if(WithdrawAmount > GetAccount.Balance || WithdrawAmount > 5000) return false;
                    else GetAccount.Balance -= WithdrawAmount;
                }
                _CONTEXT.Accounts.Update(GetAccount);
                _CONTEXT.SaveChanges();
                return true;
            }
        }
    }
}