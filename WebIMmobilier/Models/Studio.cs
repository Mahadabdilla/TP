using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebIMmobilier.Models
{
    public class Studio : Bien
    {
        [Display(Name = "Nombre de piece"), Required(ErrorMessage = "*")]
        public int NbreDePiece { get; set; }
    }
}