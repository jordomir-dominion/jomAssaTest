namespace Assa.Domain.Entities
{
    /// <summary>
    /// CarBand model
    /// </summary>
    public class CarBrand
    {
        #region Public Properties

        /// <summary>
        /// Car brand code
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Car brand name
        /// </summary>
        public string? Name { get; set; }

        #endregion Public Properties
    }
}