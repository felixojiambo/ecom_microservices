using AutoMapper;
using Mserve.Services.CouponAPI.Dtos;
using Mserve.Services.CouponAPI.Models;

namespace Mserve.Services.CouponAPI
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
