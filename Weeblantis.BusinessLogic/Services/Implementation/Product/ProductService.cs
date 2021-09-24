using Weeblantis.BusinessLogic.Services.Product;
using Weeblantis.Core.Models.Product;
using Weeblantis.Data.Repositories;

namespace Weeblantis.BusinessLogic.Services.Implementation.Product
{
    public class ProductService : IProductService
    {
        private IRepository<ProductModel> _productRepository;

        public ProductService(IRepository<ProductModel> productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
