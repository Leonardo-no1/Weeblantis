using System.Collections.Generic;
using Weeblantis.Core.Dtos.Product;

namespace Weeblantis.BusinessLogic.Services.Product
{
    public interface IProductService
    {
        ProductDto AddProduct(ProductDto productDto);
        ProductDto GetProductById(int id);
        List<ProductDto> GetAllProducts();
        List<ProductDto> GetAllProductsByCategory(int categoryId);
        ProductDto UpdateProduct(int id, ProductDto productDto);
    }
}
