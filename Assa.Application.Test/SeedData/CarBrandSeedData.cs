using Assa.ApiResources.SeedData;
using Assa.Application.Models;

namespace Assa.Application.Test.SeedData
{
    /// <summary>
    /// Seed data for CarBrand.
    /// </summary>
    public static class CarBrandViewModelSeedData
    {
        #region Public Methods

        /// <summary>
        /// Returns a list of the model
        /// </summary>
        /// <returns></returns>
        public static List<CarBrandViewModel> GetData() => CarBrandSeedData.GetData(DateTime.Now).Select(x => new CarBrandViewModel()
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code
        }).ToList();

        #endregion Public Methods
    }
}