using Lumos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lumos.Infrastucture.EntityConfigurations
{
    internal class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public virtual void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(x => x.CartItemId);
            builder.Property(x => x.CartItemId).ValueGeneratedOnAdd();

            builder.Property(x => x.Quantity).IsRequired();
        }
    }
}
