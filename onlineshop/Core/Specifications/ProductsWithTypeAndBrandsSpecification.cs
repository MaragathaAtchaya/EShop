using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductsWithTypeAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypeAndBrandsSpecification(ProductSpecParams productParams): 
            base(x=> 
            (string.IsNullOrEmpty(productParams.Search)|| x.Name.ToLower().Contains(productParams.Search))&&
            (!productParams.brandId.HasValue|| x.ProductBrandId== productParams.brandId) &&
            (!productParams.typrId.HasValue ||x.ProductTypeId==productParams.typrId))
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize*(productParams.PageIndex - 1)  , productParams.PageSize);

            if(!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n=>n.Name); 
                        break;
                }
            }
        }

        public ProductsWithTypeAndBrandsSpecification(int id)
            : base(x=>x.Id==id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
