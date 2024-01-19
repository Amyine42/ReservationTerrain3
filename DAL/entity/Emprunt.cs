using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.entity
{
    public class Emprunt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //incrementation auto id
        public int Id { get; set; }
        [Required]

        public DateTime Date { get; set; }
        [Required]

        public int IdUtilisateur { get; set; }
        [Required]

        public int IdTerrain { get; set; }
    }
}

