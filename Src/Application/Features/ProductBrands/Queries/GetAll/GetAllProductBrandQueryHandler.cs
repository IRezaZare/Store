using Application.Contracts;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProductBrands.Queries.GetAll;

public class GetAllProductBrandQueryHandler : IRequestHandler<GetAllProductBrandQuery, IEnumerable<ProductBrand>>
{
    private readonly IUnitOWork _uow;
    public GetAllProductBrandQueryHandler(IUnitOWork uow)
    {
        _uow = uow;
    }
    public async Task<IEnumerable<ProductBrand>> Handle(GetAllProductBrandQuery request, CancellationToken cancellationToken)
    {
        return await _uow.Repositry<ProductBrand>().GetAllAsync(cancellationToken);
    }
}
