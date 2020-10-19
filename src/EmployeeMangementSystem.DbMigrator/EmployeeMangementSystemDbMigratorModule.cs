using EmployeeMangementSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EmployeeMangementSystem.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EmployeeMangementSystemEntityFrameworkCoreDbMigrationsModule),
        typeof(EmployeeMangementSystemApplicationContractsModule)
        )]
    public class EmployeeMangementSystemDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
