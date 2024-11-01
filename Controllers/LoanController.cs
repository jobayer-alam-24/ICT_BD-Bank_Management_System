using ICT_BD_Bank_Management_System.enums;
using ICT_BD_Bank_Management_System.models;

namespace ICT_BD_Bank_Management_System.accountController
{
    public static class LoanController
    {
        public static Loan CreateA_Loan(Loan loan)
        {
            Console.Write($"Enter Your Loan Amount: ");
            loan.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Enter Your Loan Interest Rate: ");
            loan.InterestRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Enter Loan Term: ");
            loan.Term = int.Parse(Console.ReadLine());
            loan.StartedAt = DateTime.Now;
            loan.EndedAt = DateTime.Now.AddMonths(1);
            loan.LoanStatus = LoanStatus.Pending;
            loan.LoanTypes = LoanTypes.Monthly;
            Thread.Sleep(3000);
            Console.WriteLine($"-------------------------\nMessege: Loan Request Submitted Successfully!\n-------------------------");
            
            return loan;
        }
        public static Loan UpdateLoan(Loan loan)
        {
            Console.WriteLine($"-------------Updating Loan------------");
            Console.Write($"Enter Your Loan Amount: ");
            loan.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Enter Your Loan Interest Rate: ");
            loan.InterestRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Enter Loan Term: ");
            loan.Term = int.Parse(Console.ReadLine());
            loan.StartedAt = DateTime.Now;
            loan.EndedAt = DateTime.Now.AddMonths(1);
            loan.LoanStatus = LoanStatus.Pending;
            loan.LoanTypes = LoanTypes.Monthly;
            
            return loan;
        }
        public static void PrintSpecificLoanDetailsByID(Loan loan)
        {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Found Loan Info: {loan.ID}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Loan Amount: {loan.Amount}");
            Console.WriteLine($"Interest Rate: {loan.InterestRate}$");
            Console.WriteLine($"Term: {loan.Term}");
            Console.WriteLine($"Open Date: {loan.StartedAt}");
            Console.WriteLine($"Close Date: {loan.EndedAt}");
        }
    }
}

