using Microsoft.EntityFrameworkCore;
using PwaTest.Books;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace PwaTest.EntityFrameworkCore
{
    public static class PwaTestDbContextModelCreatingExtensions
    {
        public static void ConfigurePwaTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));


            builder.Entity<Book>(b =>
            {
                b.ToTable(PwaTestConsts.DbTablePrefix + "Books",
                    PwaTestConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PwaTestConsts.DbTablePrefix + "YourEntities", PwaTestConsts.DbSchema);

            //    //...
            //});
        }
    }
}