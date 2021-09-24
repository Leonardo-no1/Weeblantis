using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Dtos.Product;
using Weeblantis.Core.Models.Product;
using Weeblantis.Data.Repositories;

namespace Weeblantis.BusinessLogic.Services.Implementation.Product
{
    public class ProductService : IProductService
    {
        private IRepository<ProductModel> _productRepository;
        public readonly IMapper _mapper;
        private IRepository<ProductCategoryModel> _productCategoryRepository;


        public ProductService(IRepository<ProductModel> productRepository, IRepository<ProductCategoryModel> productCategoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
        }

        public ProductDto AddProduct(ProductDto productDto)
        {
            var product = _mapper.Map<ProductModel>(productDto);
            var productCategory = _productCategoryRepository.GetById(productDto.ProductCategoryId);
            if (productCategory == null)
            {
                throw new NullReferenceException();
            }
            product.ProductCategory = productCategory;
            var addedProduct = _productRepository.Insert(product);

            return _mapper.Map<ProductDto>(addedProduct);
        }

        public ProductDto UpdateProduct(int id, ProductDto productDto)
        {
            var product = _mapper.Map<ProductModel>(productDto);

            var toUpdate = _productRepository.GetById(id);
            toUpdate.Name = product.Name;
            toUpdate.Description = product.Description;
            product.ModifiedAt = DateTime.UtcNow;

            var updatedproduct = _productRepository.Update(toUpdate);

            return _mapper.Map<ProductDto>(updatedproduct);
        }

        public List<ProductDto> GetAllProducts()
        {
            var products = _productRepository.GetAll();

            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDto GetProductById(int id)
        {
            var product = _productRepository.GetById(id);

            return _mapper.Map<ProductDto>(product);
        }

        public List<ProductDto> GetAllProductsByCategory(int categoryId)
        {
            var products = _productRepository.GetAll().Where((product) => product.ProductCategoryId == categoryId );
            return _mapper.Map<List<ProductDto>>(products);

        }
    }
}
