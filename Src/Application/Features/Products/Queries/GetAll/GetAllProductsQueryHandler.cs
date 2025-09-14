using Application.Contracts;
using Application.Dtos.Products;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetAll;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>
{
    private readonly IUnitOWork _uow;
    private readonly IMapper _mapper;
    public GetAllProductsQueryHandler(IUnitOWork uow , IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var spec = new GetProductSpec();
        var result = await _uow.Repository<Product>().ListAsyncSpec(spec , cancellationToken);
        return _mapper.Map<IEnumerable<ProductDto>>(result);
        //return await _uow.Repository<Product>().GetAllAsync(cancellationToken);

    }
}
