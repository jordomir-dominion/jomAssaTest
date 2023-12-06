namespace Assa.Domain.Base.Repositories
{
    /// <summary>
    /// Repository base contract
    /// </summary>
    /// <typeparam name="TAggregate"></typeparam>
    public interface IRepositoryBase<out TAggregate> where TAggregate : class
    {
        #region Public Methods

        /// <summary>
        /// Returns this object typed as <see cref="IQueryable{TAggregate}" />.
        /// </summary>
        /// <returns></returns>
        IQueryable<TAggregate> GetQueryable();

        #endregion Public Methods
    }
}