using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.BLL.Mapping
{
    public class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<BanTypeCategory, BanTypeCategoryDto>().ReverseMap();
            CreateMap<CityCategory, CityCategoryDto>().ReverseMap();
            CreateMap<ColorCategory, ColorCategoryDto>().ReverseMap();
            CreateMap<EngineCapacityCategory, EngineCapacityCategoryDto>().ReverseMap();
            CreateMap<FuelTypeCategory, FuelTypeCategoryDto>().ReverseMap();
            CreateMap<GearBoxCategory, GearBoxCategoryDto>().ReverseMap();
            CreateMap<GearCategory, GearCategoryDto>().ReverseMap();
            CreateMap<HowManyOwnerCategory, HowManyOwnerCategoryDto>().ReverseMap();
            CreateMap<MarkaCategory, MarkaCategoryDto>().ReverseMap();
            CreateMap<MarketAssembledCategory, MarketAssembledCategoryDto>().ReverseMap();
            CreateMap<ModelCategory, ModelCategoryDto>().ReverseMap();
            CreateMap<VehicleSupplyCategory, VehicleSupplyCategoryDto>().ReverseMap();
            CreateMap<YearCategory, YearCategoryDto>().ReverseMap();
        }
    }
}
