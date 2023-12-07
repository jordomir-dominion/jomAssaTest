using Assa.ApiResources.SeedData;
using Assa.Application.Models;
using Assa.Application.Services.Controllers;
using Assa.Domain.Base.Repositories;
using Assa.Domain.Entities;
using Moq;

namespace Assa.Application.Test.ApiResources
{
    public class CarBrandControllerServiceTests
    {
        #region Public Methods

        [Fact]
        public void GetCarBrands_Returns_CorrectData()
        {
            // Arrange
            var date = DateTime.Now;
            var mockRepository = new Mock<IRepositoryBase<CarBrand>>();
            mockRepository.Setup(repo => repo.GetQueryable())
                .Returns(CarBrandSeedData.GetData(date).AsQueryable());

            var service = new CarBrandControllerService(mockRepository.Object);

            // Act
            var result = service.GetCarBrands();

            // Assert
            Assert.NotNull(result);

            var carBrandViewModels = Assert.IsType<List<CarBrandViewModel>>(result);
            Assert.Equal(3, carBrandViewModels.Count);

            Assert.Equal("hyundai", carBrandViewModels[0].Code);
            Assert.Equal("Hyundai", carBrandViewModels[0].Name);
            Assert.Equal(1, carBrandViewModels[0].Id);

        }

        #endregion Public Methods
    }
}