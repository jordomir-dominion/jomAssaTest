using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assa.Infrastructure.Data.Extensions
{
    internal static class ModelBuilderExtensions
    {
        #region Public Methods

        /// <summary>
        /// Applies configuration from all <see cref="IEntityTypeConfiguration{TEntity}" />
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void ConfigureAssaDbContext(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #endregion Public Methods
    }
}