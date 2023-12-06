namespace Assa.Application.Models
{
    /// <summary>
    /// Data transfer object for the model <see cref="Domain.Entities.Model.CarBrand"/>
    /// </summary>
    public class CarBrandViewModel
    {
        #region Public Properties

        /// <summary>
        /// Car brand code
        /// </summary>
        public string? Code { get; set; }

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