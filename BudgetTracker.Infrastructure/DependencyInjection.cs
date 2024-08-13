using BudgetTracker.Core.Interfaces;
using BudgetTracker.Infrastructure.Data;
using BudgetTracker.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Infrastructure
{
    public static class DependencyInjection
    {
       
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Data Source=DILSHAD\\DILSHAD;Initial Catalog=BudgetTracker;User ID=sa;Password=7275;Encrypt=false");
            });
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            return services;
        }
    }
}
