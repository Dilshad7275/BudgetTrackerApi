using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Core.Models
{
    public class TransactionSubType
    {
        [Key]
        public int TransactionSubTypeId { get; set; }
        public string TransactionSubTypeName { get; set; } = null!;

        public TransactionType TransactionType { get; set; } = null!;
        public int TransactionTypeId { get; set; }

    }
}
