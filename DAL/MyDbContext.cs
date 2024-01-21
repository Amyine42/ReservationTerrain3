
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
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Terrain> Terrains { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
