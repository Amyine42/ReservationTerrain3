using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.entity
{
    public class Terrain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //incrementation auto id

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Ville { get; set; }
        [Required]

        public string Quartier { get; set; }
        [Required]

        public Decimal Prix { get; set; }

        public String Description { get; set; }

    }
}
