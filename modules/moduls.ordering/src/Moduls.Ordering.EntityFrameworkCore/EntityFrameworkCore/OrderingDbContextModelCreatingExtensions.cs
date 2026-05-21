using Microsoft.EntityFrameworkCore;
using Moduls.Ordering.Orders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Moduls.Ordering.EntityFrameworkCore;

public static class OrderingDbContextModelCreatingExtensions
{
    public static void ConfigureOrdering(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Order>(b =>
        {
            //Configure table name
            b.ToTable(OrderingDbProperties.DbTablePrefix + "Orders",
                      OrderingDbProperties.DbSchema);

            //Always call this method to set base entity properties
            b.ConfigureByConvention();

            //Properties of the entity
            b.Property(q => q.CustomerName).IsRequired().HasMaxLength(120);
        });

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(OrderingDbProperties.DbTablePrefix + "Questions", OrderingDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
