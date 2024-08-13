using BudgetTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<TransactionSubType> TransactionSubType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TransactionSubType>();

            //    //modelBuilder.Entity<Transaction>()
            //    //        .HasMany(e => e.TransactionType)
            //    //        .WithOne(e => e.TransactionType)
            //    //        .HasForeignKey(e => e.TransactionTypeId)
            //    //        .HasPrincipalKey(e => e.TransactionId);

            //     modelBuilder.Entity<TransactionSubType>()
            //                   .HasOne(x=>x.TransactionType)
            //                   .WithMany(x=>x.)
        }
    }
}
