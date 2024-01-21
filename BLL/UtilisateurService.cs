using DAL.entity;
using DAL.repos;
using Models.Inscription;
using Models.Utilisateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UtilisateurService
    {
        public List<UtilisateurListe> GetListUtilisateur()
        {
            UtilisateurRepos utilisateurRepos = new UtilisateurRepos();
            List<UtilisateurListe> list = new List<UtilisateurListe>();

            foreach (var item in utilisateurRepos.GetAll())
            {
                UtilisateurListe obj = new UtilisateurListe
                {
                    Email = item.Email,
                    Id = item.Id,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    Tel = item.Tel,
                };
                list.Add(obj);
            }


            return list;
        }


        public void AjouterUtilisateur(AdminCreateUtilisateur model)
        {
            UtilisateurRepos repos = new UtilisateurRepos();
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Email = model.Email;
            utilisateur.Tel = model.Tel;
            utilisateur.Nom = model.Nom;
            utilisateur.Prenom = model.Prenom;
            utilisateur.MotPasse = model.MotPasse;

            repos.Create(utilisateur);

        }

        public void CreationCompte(InscriptionVM model)
        {
            UtilisateurRepos repos = new UtilisateurRepos();
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Email = model.EMail;
            utilisateur.Tel = model.Tel;
            utilisateur.Nom = model.Nom;
            utilisateur.Prenom = model.Prenom;
            utilisateur.MotPasse = model.MotDePasse1;


            repos.Create(utilisateur);

        }
    }
}
