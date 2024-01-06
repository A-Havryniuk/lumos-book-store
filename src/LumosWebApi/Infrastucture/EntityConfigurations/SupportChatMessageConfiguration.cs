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
    internal class SupportChatMessageConfiguration : IEntityTypeConfiguration<SupportChatMessage>
    {
        public virtual void Configure(EntityTypeBuilder<SupportChatMessage> builder)
        {
            builder.HasKey(x => x.SupportChatId);
            builder.Property(x => x.SupportChatId).ValueGeneratedOnAdd();

            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.Date).IsRequired();
        }
    }
}
