using BudgetTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BudgetTracker.Core.Interfaces.IService
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transactions>> GetAllTransactions();

        Task<Transactions> AddTransaction(Transactions transaction);
    }
}
