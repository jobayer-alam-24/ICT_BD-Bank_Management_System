using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.services
{
    public static class AccountService
    {
        private static BankManagementSystemDBContext _CONTEXT;
        static AccountService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }
        public static void AddAccount(Account account)
        {
            if(!string.IsNullOrEmpty(account.Number) && !(account.Balance <= 0))
            {
                _CONTEXT.Accounts.Add(account);
                _CONTEXT.SaveChanges();
            }
            else throw new ArgumentNullException("Empty Account Adding Is Not Allowed!");
        }
        public static string RemoveAccount(int id)
        {
            Account GetAccount = FoundAccountById(id);
            if(GetAccount != null)
            {
                _CONTEXT.Accounts.Remove(GetAccount);
                _CONTEXT.SaveChanges();
                return "Messege: Account Removed Successfully!";
            } 
            else throw new ArgumentNullException("Account Not Found.");
        }
        public static string UpdateAccount(int id, Account account)
        {
            Account GetExistingAccount = FoundAccountById(id);
            if(GetExistingAccount != null)
            {
                GetExistingAccount.Number = account.Number;
                GetExistingAccount.Balance = account.Balance;
                GetExistingAccount.OpenedAt = account.OpenedAt;
                GetExistingAccount.ClosedAt = account.ClosedAt;
                GetExistingAccount.AccountTypes = account.AccountTypes;
                GetExistingAccount.AccountStatus = account.AccountStatus;

                _CONTEXT.SaveChanges();

                return "Messege: Account Updated Successfully!";
            }
            else throw new ArgumentNullException("Empty Account is not Possible to Update.");
        }
        public static Account FoundAccountById(int id)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID. ID must be positive.");
            else return _CONTEXT.Accounts.Where(x => x.ID == id).FirstOrDefault();
        }
    }
}