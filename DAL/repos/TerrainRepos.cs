using DAL.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.repos
{
    public class TerrainRepos
    {
        public void Create(Terrain entity)
        {
            MyDbContext mydb = new MyDbContext();
            mydb.Terrains.Add(entity);
            mydb.SaveChanges();
        }

        public Terrain Read(int id)
        {
            MyDbContext mydb = new MyDbContext();
            return mydb.Terrains.Find(id);
        }

        public List<Terrain> ReadAll()
        {
            MyDbContext mydb = new MyDbContext();
            return mydb.Terrains.ToList();
        }
    }
}
