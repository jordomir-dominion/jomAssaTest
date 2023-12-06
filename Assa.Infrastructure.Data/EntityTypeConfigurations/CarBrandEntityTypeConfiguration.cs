using Assa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assa.Infrastructure.Data.EntityTypeConfigurations
{
    /// <summary>
    /// Allows the configuration of a <see cref="CarBrand"/> entity type
    /// </summary>
    internal class CarBrandEntityTypeConfiguration : IEntityTypeConfiguration<CarBrand>
    {
        #region Public Methods

        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(256);
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.CreationDate).HasColumnType("Date");
        }

        #endregion Public Methods
    }
}