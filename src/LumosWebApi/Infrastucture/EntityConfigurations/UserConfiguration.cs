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
    internal class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public virtual void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.Property(p => p.UserId).ValueGeneratedOnAdd();

            builder.Property(u => u.UserName).IsRequired();

            builder.Property(u => u.PasswordHash).IsRequired();

            builder.Property(u => u.Salt).IsRequired();



        }
    }
}
