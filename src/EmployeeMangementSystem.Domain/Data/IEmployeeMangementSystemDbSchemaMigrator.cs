using System.Threading.Tasks;

namespace EmployeeMangementSystem.Data
{
    public interface IEmployeeMangementSystemDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
