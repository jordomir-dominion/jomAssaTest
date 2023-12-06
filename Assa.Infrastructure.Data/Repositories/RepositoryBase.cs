using Assa.Domain.Base.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assa.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Repository base for entities
    /// </summary>
    /// <typeparam name="TAggregate"></typeparam>
    public class RepositoryBase<TAggregate> : IRepositoryBase<TAggregate> where TAggregate : class
    {
        #region Private Fields

        private readonly DbContext context;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Construct a new instance of <see cref="RepositoryBase{TAggregate}"/>
        /// </summary>
        /// <param name="context"></param>
        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <inheritdoc />
        public IQueryable<TAggregate> GetQueryable()
        {
            return this.context.Set<TAggregate>().AsQueryable();
        }

        #endregion Public Methods
    }
}