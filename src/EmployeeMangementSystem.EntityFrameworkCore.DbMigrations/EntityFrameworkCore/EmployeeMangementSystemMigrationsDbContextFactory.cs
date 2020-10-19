using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EmployeeMangementSystem.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class EmployeeMangementSystemMigrationsDbContextFactory : IDesignTimeDbContextFactory<EmployeeMangementSystemMigrationsDbContext>
    {
        public EmployeeMangementSystemMigrationsDbContext CreateDbContext(string[] args)
        {
            EmployeeMangementSystemEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<EmployeeMangementSystemMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new EmployeeMangementSystemMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EmployeeMangementSystem.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
