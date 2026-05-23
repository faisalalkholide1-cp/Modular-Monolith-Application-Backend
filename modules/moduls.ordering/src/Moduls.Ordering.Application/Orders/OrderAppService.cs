using Catalog.Integration;
using ModularCrm.Ordering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace Moduls.Ordering.Orders
{
    public class OrderAppService : OrderingAppService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _orderRepository;
        private readonly IProductIntegrationService _productIntegrationService;
        private readonly IDistributedEventBus _distributedEventBus;


        public OrderAppService(
            IRepository<Order, Guid> orderRepository,
        IProductIntegrationService productIntegrationService
        , IDistributedEventBus distributedEventBus
            )
        {
            _orderRepository = orderRepository;
            _productIntegrationService = productIntegrationService;
            _distributedEventBus = distributedEventBus;
        }

        public async Task<List<OrderDto>> GetListAsync()
        {
            var orders = await _orderRepository.GetListAsync();

            var productIds = orders.Select(o => o.ProductId).Distinct().ToList();
            var products = (await _productIntegrationService
                    .GetProductsByIdsAsync(productIds))
                .ToDictionary(p => p.Id, p => p.Name);

            var orderDtos = ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);

            orderDtos.ForEach(orderDto =>
            {
                if (products.TryGetValue(orderDto.ProductId, out var productName))
                {
                    orderDto.ProductName = productName;
                }
                else
                {
                    orderDto.ProductName = "Unknown Product (Deleted)";
                }
            });

            return orderDtos;
        }

        public async Task CreateAsync(OrderCreationDto input)
        {
            var order = new Order
            {
                CustomerName = input.CustomerName,
                ProductId = input.ProductId,
                State = OrderState.Placed
            };

            await _orderRepository.InsertAsync(order);

            await _distributedEventBus.PublishAsync(
                new OrderPlacedEto
                {
                    ProductId = order.ProductId,
                    CustomerName = order.CustomerName
                });
        }
    }
}
