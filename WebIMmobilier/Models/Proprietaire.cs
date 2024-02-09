using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebIMmobilier.Models
{
    public class Proprietaire: Utilisateur
    {
        [Key]
        public int IdProprio { get; set; }

        
    }

}