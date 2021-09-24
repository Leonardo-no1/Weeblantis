using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Dtos.Product;
using Weeblantis.Core.Models.Product;

namespace Weeblantis.Core.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, ProductModel>()
                .ReverseMap();
        }
    }
}
