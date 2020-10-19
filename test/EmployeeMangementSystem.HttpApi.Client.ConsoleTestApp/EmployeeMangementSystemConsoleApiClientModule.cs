using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EmployeeMangementSystem.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(EmployeeMangementSystemHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class EmployeeMangementSystemConsoleApiClientModule : AbpModule
    {
        
    }
}
