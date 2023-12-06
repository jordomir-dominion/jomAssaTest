using Microsoft.EntityFrameworkCore;

namespace Assa.Infrastructure.Data.Extensions
{
    public static class DbContextExtensions
    {
        #region Public Methods

        /// <summary>
        /// If no record exists, add the entities list
        /// </summary>
        /// <typeparam name="TAggregate"></typeparam>
        /// <param name="dbContext"></param>
        /// <param name="entities"></param>
        public static void SeedData<TAggregate>(this DbContext dbContext, IList<TAggregate> entities)
            where TAggregate : class
        {
            if (dbContext.Set<TAggregate>().Any())
                return;

            dbContext.Set<TAggregate>().AddRange(entities);

            dbContext.SaveChanges();
        }

        #endregion Public Methods
    }
}