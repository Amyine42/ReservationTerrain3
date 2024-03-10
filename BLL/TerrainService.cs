using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Terrain;
using DAL.repos;
using DAL.entity;


namespace BLL
{
    public class TerrainService
    {
        public List<TerrainListe> ListParCategorie(int idCategorie)
        {
            var list = new List<Models.Terrain.TerrainListe>();

            //Phase 1 

            TerrainRepos repos = new TerrainRepos();



            foreach (var item in repos.ReadAll())
            {
                TerrainListe obj = new TerrainListe()
                { Description = item.Description, Id = item.Id, Nom = item.Name, Prix = item.Prix };
                list.Add(obj);
            }

            return list;

        }

        public TerrainDetail Detail(int id)
        {
            var source = new TerrainRepos();
            var objSource = source.Read(id);


            TerrainDetail obj = new TerrainDetail();

            obj.Id = objSource.Id;
            obj.Description = objSource.Description;
            obj.Prix = objSource.Prix;


            return obj;
        }


        public void Create(AdminTerrainAjouter obj)
        {
            var source = new TerrainRepos();
            Terrain terrain = new Terrain();
            terrain.Prix = obj.Prix;
            terrain.Name = obj.Name;
            terrain.Quartier = obj.Quartier;

            source.Create(terrain);
        }
    }
}