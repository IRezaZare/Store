using Application.Contracts;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetAll;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Domain.Entities.Product>>
{
    private readonly IUnitOWork _uow;
    public GetAllProductsQueryHandler(IUnitOWork uow)
    {
        _uow = uow;
    }
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _uow.Repositry<Product>().GetAllAsync(cancellationToken);

    }
}
