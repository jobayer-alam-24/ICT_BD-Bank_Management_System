using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT_BD_Bank_Management_System.models;
using Microsoft.EntityFrameworkCore;

namespace ICT_BD_Bank_Management_System
{
    public class BankManagementSystemDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Loan> Loans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BankingManagementSystem;Trusted_Connection=true;Encrypt=false;MultipleActiveResultSets=true");
        }
    }
}