using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Inscription
{
    public class InscriptionVM
    {
       

        [Required(ErrorMessage = "Tapez votre EMail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        

       

        [Required(ErrorMessage = "Tapez votre Mot de passe")]
        [DataType(DataType.Password)]
        public string MotPasse { get; set; } = string.Empty;

       

        


    }
}