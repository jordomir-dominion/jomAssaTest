using Assa.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assa.ApiResources.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarBrandsController : ControllerBase
    {
        public CarBrandsController()
        {
        }

        [HttpGet(Name = "GetCarBrand")]
        public IEnumerable<CarBrandViewModel> Get()
        {
            return Enumerable.Empty<CarBrandViewModel>();
        }
    }
}