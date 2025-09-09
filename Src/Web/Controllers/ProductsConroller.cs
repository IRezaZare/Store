using Application.Contracts;
using Domain.Entities;
using Web.Common;

namespace Web.Controllers;

public class ProductsConroller : BaseApiController
{
    private readonly IGenericRepositry<Product> _repositry;
}
