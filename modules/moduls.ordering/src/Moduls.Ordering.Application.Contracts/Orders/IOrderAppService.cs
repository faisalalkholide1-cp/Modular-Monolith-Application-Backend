using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Moduls.Ordering.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<List<OrderDto>> GetListAsync();
        Task CreateAsync(OrderCreationDto input);
    }
}
