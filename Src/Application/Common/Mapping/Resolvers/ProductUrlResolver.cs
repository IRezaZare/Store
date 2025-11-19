using Application.Dtos.Products;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Application.Common.Mapping.Resolvers;

public class ProductUrlResolver(IConfiguration configuration) : IValueResolver<Product , ProductDto , string>
{
    public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
    {
        if (!string.IsNullOrEmpty(source.PictureUrl)) 
            return configuration["BackendUrl"] + configuration["LocationImages:ProductsImageLocation"] + source.PictureUrl;
        return null;
    }
}