using EmployeeMangementSystem.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EmployeeMangementSystem
{
    [DependsOn(
        typeof(EmployeeMangementSystemEntityFrameworkCoreTestModule)
        )]
    public class EmployeeMangementSystemDomainTestModule : AbpModule
    {

    }
}