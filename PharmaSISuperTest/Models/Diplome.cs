using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Diplome
    {
        public int IdDiplome { get; set; }
        public string Libelle { get; set; }
        public decimal? Quantite { get; set; }

        // Navigation
        public virtual ICollection<Product> Produits { get; set; } = new List<Product>();
    }
}