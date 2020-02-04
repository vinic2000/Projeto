using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Projeto.Models.Cliente> Cliente { get; set; }
    }
}
