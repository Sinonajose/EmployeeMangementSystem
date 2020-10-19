using Volo.Abp.Modularity;

namespace EmployeeMangementSystem
{
    [DependsOn(
        typeof(EmployeeMangementSystemApplicationModule),
        typeof(EmployeeMangementSystemDomainTestModule)
        )]
    public class EmployeeMangementSystemApplicationTestModule : AbpModule
    {

    }
}