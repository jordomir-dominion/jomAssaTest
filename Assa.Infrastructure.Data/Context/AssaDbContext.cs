using Assa.Domain.Entities;
using Assa.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Assa.Infrastructure.Data.Context
{
    public class AssaDbContext : DbContext
    {
        #region Public Constructors

        public AssaDbContext(DbContextOptions<AssaDbContext> options)
            : base(options)
        {
        }

        #endregion Public Constructors

        #region Protected Methods

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureAssaDbContext();
        }

        #endregion Protected Methods

        #region Public Properties

        public DbSet<CarBrand> CarBrands { get; set; }

        #endregion Public Properties
    }
}