using Assa.Domain.Base.Repositories;

namespace Assa.Application.Services.Controllers.Base
{
    /// <summary>
    /// Abstract class for controller service base logic.
    /// </summary>
    /// <typeparam name="TAggregate"></typeparam>
    public abstract class ControllerServiceBase<TAggregate> : IControllerServiceBase<TAggregate> where TAggregate : class
    {
        #region Protected Fields

        protected readonly IRepositoryBase<TAggregate> RepositoryBase;

        #endregion Protected Fields

        #region Public Constructors

        /// <summary>
        /// Cto protected.
        /// </summary>
        /// <param name="repositoryBase"></param>
        protected ControllerServiceBase(IRepositoryBase<TAggregate> repositoryBase)
        {
            this.RepositoryBase = repositoryBase;
        }

        #endregion Public Constructors
    }
}