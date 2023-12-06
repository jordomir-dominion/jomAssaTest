using Assa.Application.Models;
using Assa.Application.Services.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Assa.ApiResources.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarBrandsController : ControllerBase
    {
        #region Private Fields

        private readonly ICarBrandControllerService service;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Construct a new instance of <see cref="CarBrandsController"/>
        /// </summary>
        /// <param name="service"></param>
        public CarBrandsController(ICarBrandControllerService service)
        {
            this.service = service;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet(Name = "GetCarBrand")]
        public IEnumerable<CarBrandViewModel> Get()
        {
            return service.GetCarBrands();
        }

        #endregion Public Methods
    }
}