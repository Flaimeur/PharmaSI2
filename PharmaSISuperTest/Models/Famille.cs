using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Famille
    {
        public int IdFamille { get; set; }
        public string Libelle { get; set; }
        public string Nom { get; set; } 

        // Navigation
        public virtual ICollection<Product> Produits { get; set; } = new List<Product>();
    }
}