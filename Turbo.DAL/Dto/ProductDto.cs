﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.Enum;

namespace Turbo.DAL.Dto
{
    public class ProductDto: BaseDto
    {
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int? Phone { get; set; }
        public int? March { get; set; }
        public float? Price { get; set; }
        public string? Valyuta { get; set; }
        public int? EnginePower { get; set; }
        public string? Description { get; set; }
        public string? VINCod { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? New { get; set; }
        public string? PINPassword { get; set; }
        public string? AdvertisementNumber { get; set; }
        public int ViewCount { get; set; } = 0;

        public bool IsCredit { get; set; }
        public bool IsBarter { get; set; }
        public bool IsChecked { get; set; }
        public bool IsMarch { get; set; }
        public bool IsHis { get; set; }
        public bool IsColor { get; set; }
        public bool IsAccident { get; set; }
        public bool IsVip { get; set; }
        public bool IsPremium { get; set; }
        public ICollection<ProductImages>? ProductImages { get; set; }

        public int BanTypeCategoryId { get; set; }
        public string? BanName { get; set; }
        public int NumberOfSeatsCategoryId { get; set; }
        public string? NumberOfSeatsName { get; set; }
        public int CityCategoryId { get; set; }
        public string? CityName { get; set; }
        public int ColorCategoryId { get; set; }
        public string? ColorName { get; set; }
        public int EngineCapacityCategoryId { get; set; }
        public string? EngineName { get; set; }
        public int FuelTypeCategoryId { get; set; }
        public string? FuelName { get; set; }
        public int GearBoxCategoryId { get; set; }
        public string? GBoxnName { get; set; }
        public int GearCategoryId { get; set; }
        public string? GearName { get; set; }
        public int HowManyOwnerCategoryId { get; set; }
        public string? HowName { get; set; }
        public int MarkaCategoryId { get; set; }
        public string? MarkaName { get; set; }
        public int MarketAssembledCategoryId { get; set; }
        public string? MarketName { get; set; }
        public int ModelCategoryId { get; set; }
        public string? ModelName { get; set; }
        //public  List<int> VehicleSupplyCategoryId { get; set; }
        //public string? VehicleName { get; set; }
        public int YearCategoryId { get; set; }
        public string? YearName { get; set; }

        public List<BanTypeCategoryDto>? BanTypeCategoryDtos { get; set; }
        public List<NumberOfSeatsCategoryDto>? NumberOfSeatsCategoryDtos { get; set; }
        public List<CityCategoryDto>? CityCategoryDtos { get; set; }
        public List<ColorCategoryDto>? ColorCategoryDtos { get; set; }
        public List<EngineCapacityCategoryDto>? EngineCapacityCategoryDtos { get; set; }
        public List<FuelTypeCategoryDto>? FuelTypeCategoryDtos { get; set; }
        public List<GearBoxCategoryDto>? GearBoxCategoryDtos { get; set; }
        public List<GearCategoryDto>? GearCategoryDtos { get; set; }
        public List<HowManyOwnerCategoryDto>? HowManyOwnerCategoryDtos { get; set; }
        public List<MarkaCategoryDto>? MarkaCategoryDtos { get; set; }
        public List<MarketAssembledCategoryDto>? MarketAssembledCategoryDtos { get; set; }
        public List<ModelCategoryDto>? ModelCategoryDtos { get; set; }
        //public List<VehicleSupplyCategoryDto>? VehicleSupplyCategoryDtos { get; set; }
        public List<YearCategoryDto>? YearCategoryDtos { get; set; }

        public static string GeneratePIN()
        {
            Random generator = new Random();
            return generator.Next(10000, 99999).ToString();
        }

    }
}
