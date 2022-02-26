using Domain.KeyLessEntity;
using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persist
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<MyFile> Files { get; set; }
        public DbSet<ActiveLoan> ActiveLoans { get; set; }
        public DbSet<ActiveLoanMore> activeLoanMores { get; set; }
        public DbSet<DisActiveLoan> disActiveLoans { get; set; }
        public DbSet<DisactiveLoanMore> DisactiveLoanMores { get; set; }
        public DbSet<GetInstallment> getInstallments{ get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string id = Guid.NewGuid().ToString();
            Guid fundId = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(new User() { UserName = "test", userRoles = Domain.Enums.UserRoles.SuperAdmin, Id = id, PasswordHash = "12345", FundId = fundId });
            modelBuilder.Entity<Fund>().HasData(new Fund() { Id = fundId, FundName = "همکاران", AdminName = "test", UserId = id,FundSubmitDate=DateTime.Now });

            modelBuilder.Entity<ActiveLoan>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });
            
            modelBuilder.Entity<ActiveLoanMore>(
                   eb =>
                   {
                       eb.HasNoKey();
                   });

            modelBuilder.Entity<DisActiveLoan>(
                   eb =>
                   {
                       eb.HasNoKey();
                   });

            modelBuilder.Entity<DisactiveLoanMore>(
                  eb =>
                  {
                      eb.HasNoKey();
                  });

            modelBuilder.Entity<GetInstallment>(
                  eb =>
                  {
                      eb.HasNoKey();
                  });



        }
    }
}
