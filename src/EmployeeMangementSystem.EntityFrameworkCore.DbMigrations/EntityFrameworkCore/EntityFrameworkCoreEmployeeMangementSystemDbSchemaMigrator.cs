using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeMangementSystem.Data;
using Volo.Abp.DependencyInjection;

namespace EmployeeMangementSystem.EntityFrameworkCore
{
    public class EntityFrameworkCoreEmployeeMangementSystemDbSchemaMigrator
        : IEmployeeMangementSystemDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEmployeeMangementSystemDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EmployeeMangementSystemMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EmployeeMangementSystemMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}