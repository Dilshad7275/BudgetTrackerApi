using BudgetTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.Core.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transactions>> GetAllTransactions();

        Task<Transactions> AddTransaction(Transactions transaction);

    }
}
