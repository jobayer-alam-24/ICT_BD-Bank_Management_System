using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ICT_BD_Bank_Management_System.services
{
    public static class LoanService
    {
        private static BankManagementSystemDBContext _CONTEXT;
        static LoanService()
        {
            _CONTEXT = new BankManagementSystemDBContext();
        }
        public static void AddLoan(Loan loan)
        {
            if(loan != null)
            {
                _CONTEXT.Loans.Add(loan);
                _CONTEXT.SaveChanges();
            }
            else throw new ArgumentNullException("Vacant Loan Can not Possible To add!");
        }
        public static void AddLoanPayment(LoanPayment loanPayment)
        {
            if(loanPayment != null)
            {
                _CONTEXT.LoanPayments.Add(loanPayment);
                _CONTEXT.SaveChanges();
            }
            else throw new ArgumentNullException("Vacant Loan Payment Can not Possible To add!");
        }
        public static void UpdateLoan(int id, Loan loan)
        {
            Loan GetExistingLoan = GetLoan(id);
            if(GetExistingLoan != null)
            {
                GetExistingLoan.LoanTypes = loan.LoanTypes;
                GetExistingLoan.LoanStatus = loan.LoanStatus;
                GetExistingLoan.Amount = loan.Amount;
                GetExistingLoan.InterestRate = loan.InterestRate;
                GetExistingLoan.Term = loan.Term;
                GetExistingLoan.StartedAt = loan.StartedAt;
                GetExistingLoan.EndedAt = loan.EndedAt;
                _CONTEXT.SaveChanges();
            }
        }
        public static string RemoveLoan(int id)
        {
            Loan GetExistingLoan = GetLoan(id);
            if(GetExistingLoan != null)
            {
                _CONTEXT.Loans.Remove(GetExistingLoan);
                _CONTEXT.SaveChanges();
                return "Messege: Loan Removed Successfully!";
            }
            else throw new ArgumentNullException("Vacant Loan can not possible to Remove");
        }
        public static Loan GetLoan(int id)
        {
            if(id <= 0) throw new ArgumentException("Invalid ID");
            else return _CONTEXT.Loans.Where(x => x.ID == id).FirstOrDefault();
        }
        public static void UpdateLoanPayment(LoanPayment loanPayment)
        {
            if(loanPayment.LoanID <= 0 || loanPayment == null) throw new ArgumentException("Invalid ID");
            else
            {
                Loan GetLoanPaymentByID = GetLoan(loanPayment.LoanID);
                if(GetLoanPaymentByID == null) throw new ArgumentNullException("Empty Loan Payment");
                else
                {
                    if(GetLoanPaymentByID.DuePayment > loanPayment.PaidAmount)
                    {
                        GetLoanPaymentByID.DuePayment -= loanPayment.PaidAmount;
                    }
                    else throw new ArgumentException("Invalid Paid Amount. Check Your Loan Amount. Above Loan Amount Exception");
                }
                _CONTEXT.Loans.Update(GetLoanPaymentByID);
                _CONTEXT.SaveChanges();
            }
        }

    }
}