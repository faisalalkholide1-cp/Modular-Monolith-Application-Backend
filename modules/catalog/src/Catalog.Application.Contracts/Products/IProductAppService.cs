using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Catalog.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<List<ProductDto>> GetListAsync();
        Task CreateAsync(ProductCreationDto input);
    }
}
