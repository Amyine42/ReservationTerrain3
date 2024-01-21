using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.entity
{
    
    public class Utilisateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //incrementation auto id
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; } 
        [Required]
        public string Prenom { get; set; } 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
        public string Tel { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        public string MotPasse { get; set; } 
    }
}