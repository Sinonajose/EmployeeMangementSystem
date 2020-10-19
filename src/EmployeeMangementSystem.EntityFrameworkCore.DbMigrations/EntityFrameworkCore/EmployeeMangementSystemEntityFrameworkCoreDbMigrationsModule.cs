using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EmployeeMangementSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(EmployeeMangementSystemEntityFrameworkCoreModule)
        )]
    public class EmployeeMangementSystemEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<EmployeeMangementSystemMigrationsDbContext>();
        }
    }
}
