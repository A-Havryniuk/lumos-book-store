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
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public virtual void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(a => a.PublisherId);
            builder.Property(x => x.PublisherId).ValueGeneratedOnAdd();

            builder.Property(x => x.PublisherName).IsRequired();
        }
    }
}
