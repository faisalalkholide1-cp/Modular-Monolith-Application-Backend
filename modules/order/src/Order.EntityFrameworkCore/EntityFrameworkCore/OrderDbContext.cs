using Microsoft.EntityFrameworkCore;
using Order.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Order.EntityFrameworkCore;

[ConnectionStringName(OrderDbProperties.ConnectionStringName)]
public class OrderDbContext : AbpDbContext<OrderDbContext>, IOrderDbContext
{
    public DbSet<Ordera> Orders { get; set; }
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOrder();
    }
}
