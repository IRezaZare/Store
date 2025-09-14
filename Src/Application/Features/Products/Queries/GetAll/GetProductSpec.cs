using Application.Contracts.Specification;
using Domain.Entities;

namespace Application.Features.Products.Queries.GetAll;
 
public class GetProductSpec : BaseSpecification<Product>
{
    public GetProductSpec() : base()
    {
        Addinclude(x => x.ProductBrand);
        Addinclude(x => x.ProductType);
    }
    public GetProductSpec(int id) : base(x => x.Id == id)
    {
        
    }
}
