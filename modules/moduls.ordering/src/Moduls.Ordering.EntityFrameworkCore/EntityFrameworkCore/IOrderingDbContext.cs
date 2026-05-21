using Microsoft.EntityFrameworkCore;
using Moduls.Ordering.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Moduls.Ordering.EntityFrameworkCore;

[ConnectionStringName(OrderingDbProperties.ConnectionStringName)]
public interface IOrderingDbContext : IEfCoreDbContext
{
    DbSet<Order> Orders { get; set; }
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
