using Assa.Domain.Base.Repositories;
using Assa.Infrastructure.Data.Context;
using Assa.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Assa.Infrastructure.Data.Extensions
{
    /// <summary>
    /// Extension for <see cref="IServiceCollection"/>
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        #region Public Methods

        /// <summary>
        /// Add AssaDbContext and Generyc repository into a service collections
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddAssaDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, AssaDbContext>();
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<AssaDbContext>(builder =>
                {
                    builder.UseNpgsql(configuration.GetConnectionString("AssaConnection"));
                });

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        }

        #endregion Public Methods
    }
}