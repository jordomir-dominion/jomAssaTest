using Assa.Application.Extensions;
using Assa.Application.Services.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace Assa.Application.Test.Applications
{
    public class ServiceCollectionExtensionsTests
    {
        #region Public Methods

        [Fact]
        public void AddAssaApplication_RegistersServices()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddAssaApplication();

            // Assert
            var registeredTypes = services.Select(descriptor => descriptor.ServiceType).ToList();
            
            Assert.Contains(typeof(ICarBrandControllerService), registeredTypes);
        }

        #endregion Public Methods
    }
}