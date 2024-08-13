using BudgetTracker.Core.Interfaces.IService;
using BudgetTracker.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        public readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllTransaction()
        {
            try
            {
                var a= await _transactionService.GetAllTransactions();
                return  Ok(a);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
