using BudgetTracker.Core.Interfaces;
using BudgetTracker.Core.Models;
using BudgetTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Infrastructure.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;

        public TransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transactions>> GetAllTransactions()
        {
            //IEnumerable<Transactions> transactions = new IEnumerable<Transactions>();
            //var list= await _context.Set<Transactions>().ToListAsync();
            //transactions.

            //foreach (var transaction in list)
            //{
            //    transactions.Add(transaction);
            //}
            //return transactions;
            return await _context.Transactions.ToListAsync();
           
        }

        public Task<Transactions> AddTransaction(Transactions transaction)
        {
            _context.AddAsync<Transactions>(transaction);
            _context.SaveChangesAsync();
            return Task.FromResult(transaction);
        }
    }
}
