using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Utilisateur
{
    public class UtilisateurListe
    {
        public int Id { get; set; }
        public string Nom { get; set; } 
        public string Prenom { get; set; } 
        public string Email { get; set; } 
        public string Tel { get; set; } 
    }
}