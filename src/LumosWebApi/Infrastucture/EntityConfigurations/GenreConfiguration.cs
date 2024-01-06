using Lumos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lumos.Infrastucture.EntityConfigurations
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public virtual void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(a => a.GenreId);
            builder.Property(a => a.GenreId).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
