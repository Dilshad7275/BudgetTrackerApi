using BudgetTracker.Core.Interfaces;
using BudgetTracker.Core.Interfaces.IService;
using BudgetTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BudgetTracker.Application.Service
{
    public class TransactionService :ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository=transactionRepository;
        }

        public async Task<Transactions> AddTransaction(Transactions transaction)
        {
            return await _transactionRepository.AddTransaction(transaction);
        }

        public Task<IEnumerable<Transactions>> GetAllTransactions()
        {
            return _transactionRepository.GetAllTransactions();
        }
    }
}
