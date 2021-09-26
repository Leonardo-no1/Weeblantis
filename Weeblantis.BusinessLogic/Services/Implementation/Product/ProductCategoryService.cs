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

        public ProductCategoryDto UpdateProductCategory(int id,ProductCategoryDto productCategoryDto)
        {
            var productCategory = _mapper.Map<ProductCategoryModel>(productCategoryDto);
            
            var toUpdate = _productCategoryRepository.GetById(id);
            toUpdate.Name = productCategory.Name;
            toUpdate.Description = productCategory.Description;
            productCategory.ModifiedAt = DateTime.UtcNow;

            var updatedProductCategory = _productCategoryRepository.Update(toUpdate);

            return _mapper.Map<ProductCategoryDto>(updatedProductCategory);
        }

        public List<ProductCategoryDto> GetAllProductCategories()
        {
            var productCategories = _productCategoryRepository.GetAll();

            return _mapper.Map<List<ProductCategoryDto>>(productCategories);
        }

        public ProductCategoryDto GetProductCategoryById(int id)
        {
            var product = _productCategoryRepository.GetById(id);

            return _mapper.Map<ProductCategoryDto>(product);
        }
    }
}
