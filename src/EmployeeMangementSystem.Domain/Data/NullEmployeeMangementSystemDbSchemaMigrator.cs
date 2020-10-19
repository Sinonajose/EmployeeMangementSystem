using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EmployeeMangementSystem.Data
{
    /* This is used if database provider does't define
     * IEmployeeMangementSystemDbSchemaMigrator implementation.
     */
    public class NullEmployeeMangementSystemDbSchemaMigrator : IEmployeeMangementSystemDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}