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
        [Required(ErrorMessage = "Tapez votre nom")]
        [MinLength(3)]
        public string Nom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tapez votre Prenom")]
        [MinLength(3)]
        public string Prenom { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tapez votre EMail")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tapez votre Telephone")]


        public string Tel { get; set; } = string.Empty;

        #region "Gestion  Mot de passe"

        [Required(ErrorMessage = "Tapez votre Mot de passe")]
        [DataType(DataType.Password)]
        public string MotDePasse1 { get; set; } = string.Empty;


        [Required(ErrorMessage = "Tapez votre Mot de passe")]
        [DataType(DataType.Password)]
        [Compare("MotDePasse1")]
        public string MotDePasse2 { get; set; } = string.Empty;

        #endregion

        


    }
}