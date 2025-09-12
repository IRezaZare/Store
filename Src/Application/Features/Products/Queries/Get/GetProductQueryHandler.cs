﻿using Application.Contracts;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.Get;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
{
    private readonly IUnitOWork _uow;
    public GetProductQueryHandler(IUnitOWork uow)
    {
        _uow = uow;
    }
    public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var entity = await _uow.Repositry<Product>().GetByIdAsync(request.Id, cancellationToken);
        if (entity == null) throw new Exception("error message:");
        return entity;
    }
}
