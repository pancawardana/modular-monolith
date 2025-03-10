using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ODS.DataEntry.Shared.Data;

namespace ODS_DataEntry.Shared.Infrastructure
{
    public static class DbContextSetup
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, string connectionString, int? commandTimeout)
        {
            services
                .AddDbContext<DbContext, ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(connectionString, x => x.CommandTimeout(commandTimeout));
                })
                .AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(connectionString, x => x.CommandTimeout(commandTimeout));
                });

            return services;
        }
    }
}
