using Assa.Application.Models;
using Assa.Application.Services.Controllers.Base;
using Assa.Domain.Entities;

namespace Assa.Application.Services.Controllers
{
    /// <summary>
    /// Controller service contract for CarBrand
    /// </summary>
    public interface ICarBrandControllerService : IControllerServiceBase<CarBrand>
    {
        #region Public Methods

        /// <summary>
        /// Returns a list of the model
        /// </summary>
        /// <returns></returns>
        IEnumerable<CarBrandViewModel> GetCarBrands();

        #endregion Public Methods
    }
}