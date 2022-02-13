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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<ActiveLoan>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });
        }
    }
}
