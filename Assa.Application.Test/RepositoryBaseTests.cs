using Assa.ApiResources.SeedData;
using Assa.Domain.Entities;
using Assa.Infrastructure.Data.Context;
using Assa.Infrastructure.Data.Extensions;
using Assa.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assa.Application.Test
{
    public class RepositoryBaseTests
    {
        #region Private Fields

        private readonly AssaDbContext dbContext;

        #endregion Private Fields

        #region Public Constructors

        public RepositoryBaseTests()
        {
            // Configura las opciones para usar una base de datos en memoria
            var dbContextOptions = new DbContextOptionsBuilder<AssaDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            // Crea un nuevo contexto de base de datos en memoria para cada prueba
            var date = DateTime.Now;
            dbContext = new AssaDbContext(dbContextOptions);
            dbContext.SeedData(CarBrandSeedData.GetData(date));
        }

        #endregion Public Constructors

        #region Public Methods

        [Fact]
        public void CarBrands_DbContext_ShouldBePopulated()
        {
            // Arrange
            var carBrandsRepository = new RepositoryBase<CarBrand>(dbContext);

            // Act
            var carBrands = carBrandsRepository.GetQueryable().ToList();

            // Assert
            Assert.NotNull(carBrands);
            Assert.NotEmpty(carBrands);
            Assert.Equal(3, carBrands.Count);
        }

        #endregion Public Methods
    }
}