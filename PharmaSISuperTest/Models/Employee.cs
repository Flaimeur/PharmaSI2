using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Employee
    {
        public int IdEmploye { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Mdp { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Sexe { get; set; }
        public int? IdPoste { get; set; }

        // Navigation
        public virtual Poste Poste { get; set; }

        // Navigation
        public virtual ICollection<Product> Produits { get; set; } = new List<Product>();
    }
}