using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Core.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }
        public TransactionType TransactionType { get; set; } = null!;
        public int TransactionTypeId { get; set; } 
        public TransactionSubType TransactionSubType { get; set; } = null!;
        public int TransactionSubTypeId { get; set; }

        public double Amount { get; set; }

        public DateTime TransDateTime { get; set; } = DateTime.Now;

        public string? Comment { get; set; }
    }
}
