using Assa.ApiResources.Controllers;
using Assa.Application.Models;
using Assa.Application.Services.Controllers;
using Assa.Application.Test.SeedData;
using Moq;

namespace Assa.Application.Test
{
    public class CarBrandsControllerTests
    {
        #region Public Methods

        [Fact]
        public void Get_Returns_CorrectData()
        {
            // Arrange
            var mockService = new Mock<ICarBrandControllerService>();
            mockService.Setup(service => service.GetCarBrands())
                .Returns(CarBrandViewModelSeedData.GetData());

            var controller = new CarBrandsController(mockService.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);

            var carBrands = Assert.IsType<List<CarBrandViewModel>>(result);

            Assert.Equal(3, carBrands.Count);
        }

        #endregion Public Methods
    }
}