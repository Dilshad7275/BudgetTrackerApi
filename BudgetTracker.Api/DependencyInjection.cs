using BudgetTracker.Application;
using BudgetTracker.Core;
using BudgetTracker.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPiDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI().AddCoreDI();
            return services;
        }
    }
}
