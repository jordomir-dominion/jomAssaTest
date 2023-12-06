using Assa.Domain.Entities;

namespace Assa.ApiResources.SeedData
{
    /// <summary>
    /// Seed data for CarBrand.
    /// </summary>
    public static class CarBrandSeedData
    {
        /// <summary>
        /// Returns a list of the model
        /// </summary>
        /// <param name="creationDate"></param>
        /// <returns></returns>
        public static List<CarBrand> GetData(DateTime creationDate) => new List<CarBrand>
        {
            new CarBrand { Id = 1, Name = "Hyundai", Code = "hyundai", CreationDate = creationDate },
            new CarBrand { Id = 2, Name = "Cadillac", Code = "cadillac", CreationDate = creationDate },
            new CarBrand { Id = 3, Name = "Bmw", Code = "bmw", CreationDate = creationDate }
        };
    }
}
