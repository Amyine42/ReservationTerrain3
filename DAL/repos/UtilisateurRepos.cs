using DAL.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL.repos
{
    public class UtilisateurRepos
    {

        public void Create(Utilisateur entity)
        {
            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Utilisateurs.Add(entity);
            myDbContext.SaveChanges();
        }

        public Utilisateur Read(int id)
        {
            MyDbContext myDbContext = new MyDbContext();
            return myDbContext.Utilisateurs.Find(id); 
        }

        public List<Utilisateur> GetAll()
        {
            MyDbContext myDbContext = new MyDbContext();

            return myDbContext.Utilisateurs.ToList();
        }
    }
}
