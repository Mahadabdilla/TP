using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebIMmobilier.Models
{
    public class Terrain : Bien
    {
        [Display(Name = "type de terrain"), Required(ErrorMessage = "*")]
        public int TypeTerrain { get; set; }
    }
}