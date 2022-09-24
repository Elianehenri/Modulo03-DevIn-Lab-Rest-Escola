using Banda.Domain.Models;
using Banda.Infra.DataBase.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Infra.DataBase
{
    public class BandaDBContexto : DbContext
    {
        public DbSet<Tocar> Tocadas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Banda;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new BandaMap());
        }  
    }
}
