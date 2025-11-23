using Application.Contracts;
using Application.Dtos.Products;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetAll;

public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>> , ICacheQuery
{
    public int PageId { get; set; }
    public int HoursSaveData => 1;
}
