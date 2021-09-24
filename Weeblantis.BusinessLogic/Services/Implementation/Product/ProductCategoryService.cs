using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Dtos.Product;
using Weeblantis.Core.Models.Product;
using Weeblantis.Data.Repositories;

namespace Weeblantis.BusinessLogic.Services.Implementation.Product
{
    public class ProductCategoryService : IProductCategoryService
    {
        public readonly IMapper _mapper;
        private IRepository<ProductCategoryModel> _productCategoryRepository;

        public ProductCategoryService(IRepository<ProductCategoryModel> productCategoryRepository,IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }

        public ProductCategoryDto AddProductCategory(ProductCategoryDto productCategoryDto)
        {
            var productCategory = _mapper.Map<ProductCategoryModel>(productCategoryDto);

            var addedProductCategory = _productCategoryRepository.Insert(productCategory);

            return _mapper.Map<ProductCategoryDto>(addedProductCategory);
        }

        public ProductCategoryDto GetProductCategoryById(int id)
        {
            var addedProductCategory = _productCategoryRepository.GetById(id);

            return _mapper.Map<ProductCategoryDto>(addedProductCategory);
        }
    }
}
