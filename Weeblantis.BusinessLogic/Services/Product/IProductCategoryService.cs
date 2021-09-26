using System.Collections.Generic;
using Weeblantis.Core.Dtos.Product;

namespace Weeblantis.BusinessLogic.Services.Product
{
    public interface IProductCategoryService
    {
        ProductCategoryDto AddProductCategory(ProductCategoryDto productCategoryDto);
        ProductCategoryDto GetProductCategoryById(int id);
        List<ProductCategoryDto> GetAllProductCategories();
        ProductCategoryDto UpdateProductCategory(int id, ProductCategoryDto productCategoryDto);
    }
}
