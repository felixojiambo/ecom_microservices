using Mserve.Services.ShoppingCartAPI.Models.Dto;

namespace Mserve.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
