using Core.Entities;

namespace Core.Specification
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productsParams)
            : base(x =>
            (!productsParams.BrandId.HasValue || x.ProductBrandId == productsParams.BrandId) &&
            (!productsParams.TypeId.HasValue || x.ProductTypeId == productsParams.TypeId)    
            )  
        {
        }
    }
}