using Application.Dtos.Products;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetAll;

public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
{
    public int PageId { get; set; }
}
