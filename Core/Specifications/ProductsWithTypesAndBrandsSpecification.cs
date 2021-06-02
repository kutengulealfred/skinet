using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    { 
        // We're getting our products including types and brands
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        // We're getting specific product including type and brand
        public ProductsWithTypesAndBrandsSpecification(int id) 
            : base(x => x.Id ==id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
       
    }
}