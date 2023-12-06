using Assa.Application.Models;
using Assa.Application.Services.Controllers.Base;
using Assa.Domain.Base.Repositories;
using Assa.Domain.Entities;

namespace Assa.Application.Services.Controllers
{
    /// <summary>
    /// Controller service for CarBrand
    /// </summary>
    public class CarBrandControllerService : ControllerServiceBase<CarBrand>, ICarBrandControllerService
    {
        #region Public Constructors

        /// <summary>
        /// Construct a new instance of <see cref="CarBrandControllerService"/>
        /// </summary>
        /// <param name="carBrandRepository"></param>
        public CarBrandControllerService(IRepositoryBase<CarBrand> carBrandRepository)
            : base(carBrandRepository)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc />
        public IEnumerable<CarBrandViewModel> GetCarBrands()
        {
            return RepositoryBase.GetQueryable().Select(x => new CarBrandViewModel
            {
                Code = x.Code,
                Name = x.Name,
                Id = x.Id,
            }).ToList();
        }

        #endregion Public Methods
    }
}