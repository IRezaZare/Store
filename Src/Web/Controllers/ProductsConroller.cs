using Application.Contracts;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Common;

namespace Web.Controllers;

public class ProductsConroller : BaseApiController
{
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
