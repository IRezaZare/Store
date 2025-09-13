using Application.Features.ProductBrands.Queries.GetAll;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Common;

namespace Web.Controllers
{
    public class ProductBrandsController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductBrand>>> GetAllProductBrand(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllProductBrandQuery(), cancellationToken));
        }
    }
}
