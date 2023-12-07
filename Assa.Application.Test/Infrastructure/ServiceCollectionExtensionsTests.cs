using Assa.ApiResources.SeedData;
using Assa.Domain.Base.Repositories;
using Assa.Infrastructure.Data.Context;
using Assa.Infrastructure.Data.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Assa.Application.Test.Infrastructure
{
    public class ServiceCollectionExtensionsTests
    {
        #region Public Methods

        [Fact]
        public void AddAssaDbContext_RegistersDbContextAndRepositories()
        {
            // Arrange
            var services = new ServiceCollection();
            var configuration = new ConfigurationBuilder().AddInMemoryCollection(
                    new Dictionary<string, string>
                    {
                        {"ConnectionStrings:AssaConnection", "dummy connection string"}
                    })
                .Build();

            // Act
            services.AddAssaDbContext(configuration);

            // Assert
            var registeredTypes = services.Select(descriptor => descriptor.ServiceType).ToList();

            // Verifica que el DbContext esté registrado correctamente
            Assert.Contains(typeof(AssaDbContext), registeredTypes);

            // Verifica que el IRepositoryBase<> esté registrado correctamente
            Assert.Contains(typeof(IRepositoryBase<>), registeredTypes);

            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AssaDbContext>();

                // Assert
                Assert.NotNull(dbContext);
                // Puedes agregar más aserciones según sea necesario para verificar que el contexto se haya inicializado correctamente
            }
        }

        #endregion Public Methods
    }
}