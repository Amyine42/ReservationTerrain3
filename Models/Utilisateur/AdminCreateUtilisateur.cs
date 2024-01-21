using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Utilisateur
{
    public class AdminCreateUtilisateur
    {
        [Required]
        public string Nom { get; set; } 
        [Required]
        public string Prenom { get; set; } 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Tel { get; set; } 
        [DataType(DataType.Password)]
        public string MotPasse { get; set; }
    }
}