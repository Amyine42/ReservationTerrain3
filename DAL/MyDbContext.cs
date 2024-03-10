
using DAL.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        

        public DbSet<Terrain> Terrains { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=LAPTOP-IOH24J79\SQLEXPRESS;Initial Catalog=ResTerrainDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }

    }
}
