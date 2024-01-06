using Lumos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lumos.Infrastucture.EntityConfigurations
{
    internal class RoleConfiguration: IEntityTypeConfiguration<Role>
    {
        public virtual void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);
            builder.Property(r => r.RoleId).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
