using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lumos.Infrastucture.EntityConfigurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public virtual void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(k => k.BookId);
            builder.Property(p => p.BookId).ValueGeneratedOnAdd();

            builder.Property(p => p.Author).IsRequired();

            builder.Property(p => p.Price).IsRequired();

            builder.Property(p => p.QuantityInStock).IsRequired();


        }
    }
}
