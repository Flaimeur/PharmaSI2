using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Praticien
    {
        public int IdPraticien { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public decimal? CoefficientNotoriete { get; set; }

        // Navigation
        public virtual ICollection<TypePraticien> Types { get; set; } = new List<TypePraticien>();
        public virtual ICollection<Posseder> Certifications { get; set; } = new List<Posseder>();
    }
}