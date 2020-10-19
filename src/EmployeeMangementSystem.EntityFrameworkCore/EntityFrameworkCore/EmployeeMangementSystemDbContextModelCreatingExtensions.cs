using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace EmployeeMangementSystem.EntityFrameworkCore
{
    public static class EmployeeMangementSystemDbContextModelCreatingExtensions
    {
        public static void ConfigureEmployeeMangementSystem(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(EmployeeMangementSystemConsts.DbTablePrefix + "YourEntities", EmployeeMangementSystemConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}