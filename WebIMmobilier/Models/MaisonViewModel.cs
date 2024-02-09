using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebIMmobilier.Models
{
    public class MaisonViewModel: Bien
    {
        [Display(Name = "Nombre de chambre"), Required(ErrorMessage = "*")]
        public int NbreChambre { get; set; }

        [Display(Name = "Nombre de salle d'eau "), Required(ErrorMessage = "*")]
        public int NbreSalleEau { get; set; }

        [Display(Name = "Nombre de cuisine"), Required(ErrorMessage = "*")]
        public int NbreCuisine { get; set; }

        [Display(Name = "Nombre de toilettes "), Required(ErrorMessage = "*")]
        public int? NbreToilette { get; set; }
    }
}