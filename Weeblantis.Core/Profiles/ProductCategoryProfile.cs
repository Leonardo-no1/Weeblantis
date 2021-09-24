using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Dtos.Product;
using Weeblantis.Core.Models.Product;

namespace Weeblantis.Core.Profiles
{
    public class ProductCategoryProfile : Profile
    {
        public ProductCategoryProfile()
        {
            CreateMap<ProductCategoryDto, ProductCategoryModel>()
                .ReverseMap();
        }
    }
}
