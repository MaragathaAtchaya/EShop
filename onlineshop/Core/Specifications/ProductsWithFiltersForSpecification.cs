﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductsWithFiltersForSpecification:BaseSpecification<Product>
    {
        public ProductsWithFiltersForSpecification(ProductSpecParams productParams): base(x=>
            (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
            (!productParams.brandId.HasValue|| x.ProductBrandId== productParams.brandId) &&
            (!productParams.typrId.HasValue ||x.ProductTypeId==productParams.typrId))
        {

        }
    }
}