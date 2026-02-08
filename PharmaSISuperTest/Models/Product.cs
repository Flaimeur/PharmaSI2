using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Product
    {
        public int IdProduit { get; set; }
        public string NumeroDuProduit { get; set; }
        public decimal? PrixEchantillon { get; set; }
        public string EffetsTherapeutiques { get; set; }
        public string ContraIndications { get; set; }
        public string Interactions { get; set; }

        // Navigation
        public virtual ICollection<Famille> Familles { get; set; } = new List<Famille>();
        public virtual ICollection<Composant> Composants { get; set; } = new List<Composant>();
    }
}