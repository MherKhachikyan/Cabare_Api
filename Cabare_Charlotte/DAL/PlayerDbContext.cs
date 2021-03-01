using Cabare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cabare_Charlotte.DAL
{
    public class PlayerDbContext : DbContext
    {

        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
        }
    }
}
