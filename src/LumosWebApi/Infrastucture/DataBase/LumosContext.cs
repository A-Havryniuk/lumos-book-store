using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lumos.Infrastucture.DataBase
{
    public class LumosContext: DbContext
    {
        public LumosContext(DbContextOptions<LumosContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<SupportChat> SupportChats { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
