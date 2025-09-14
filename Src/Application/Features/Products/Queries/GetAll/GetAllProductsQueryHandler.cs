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
        var spec = new GetProductSpec();
        return await _uow.Repository<Product>().ListAsyncSpec(spec , cancellationToken);
        //return await _uow.Repository<Product>().GetAllAsync(cancellationToken);

    }
}
