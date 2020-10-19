using Microsoft.EntityFrameworkCore;
using EmployeeMangementSystem.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace EmployeeMangementSystem.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See EmployeeMangementSystemMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class EmployeeMangementSystemDbContext : AbpDbContext<EmployeeMangementSystemDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside EmployeeMangementSystemDbContextModelCreatingExtensions.ConfigureEmployeeMangementSystem
         */

        public EmployeeMangementSystemDbContext(DbContextOptions<EmployeeMangementSystemDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the EmployeeMangementSystemEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureEmployeeMangementSystem method */

            builder.ConfigureEmployeeMangementSystem();
        }
    }
}
