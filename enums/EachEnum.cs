namespace ICT_BD_Bank_Management_System.enums
{
    public enum AccountTypes
    {
        Student = 0,
        VIP, Savings, Business
    }
    public enum AccountStatus
    {
        Active = 0,
        Inactive,  
        Pending, 
        Deleted

    }
    public enum CustomerStatus
    {
        Active = 0,
        Inactive,  
        Pending, 
        Deleted 
    }
    public enum TransactionTypes
    {
        Deposit = 0,
        Withdraw
    }
    public enum LoanTypes
    {
        Monthly = 0,
        Yearly,
        One
    }
    public enum LoanStatus
    {
        Paid = 0,
        Active,
        Pending,
        Disabled,
        Deleted,
        Under_Review
    }
}