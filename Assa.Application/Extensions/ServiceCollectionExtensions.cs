using Assa.Application.Services.Controllers.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Assa.Application.Extensions
{
    /// <summary>
    /// Extension for ControllerServiceBase
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        #region Public Methods

        /// <summary>
        /// Add Assa aplication service.
        /// </summary>
        /// <param name="services"></param>
        public static void AddAssaApplication(this IServiceCollection services)
        {
            var assemblyTypes = Assembly.GetAssembly(typeof(ControllerServiceBase<>))?.GetTypes();
            if (assemblyTypes == null || assemblyTypes.Length == 0)
                return;

            foreach (var genericType in assemblyTypes.Where(x => !x.IsInterface &&
                                                                 x.GetInterfaces().Any(i => i.IsGenericType &&
                                                                     typeof(IControllerServiceBase<>).IsAssignableFrom(
                                                                         i.GetGenericTypeDefinition()))))
            {
                var serviceType = genericType.GetInterfaces().FirstOrDefault(x => x.Name == $"I{genericType.Name}");
                if (serviceType == null || serviceType.Name == typeof(IControllerServiceBase<>).Name) continue;
                services.AddTransient(serviceType, genericType);
            }
        }

        #endregion Public Methods
    }
}