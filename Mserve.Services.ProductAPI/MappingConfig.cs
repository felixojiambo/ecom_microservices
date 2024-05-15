using AutoMapper;
using Mserve.Services.ProductAPI.Models;
using Mserve.Services.ProductAPI.Models.Dto;

namespace Mserve.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
