using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models;
using Weeblantis.Core.Models.Product;

namespace Weeblantis.Core.Dtos.Product
{
    public class ProductCategoryDto : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
