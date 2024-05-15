using Mserve.Services.ShoppingCartAPI.Models.Dto;

namespace Mserve.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
