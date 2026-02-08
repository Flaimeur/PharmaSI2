using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Services
{
    public class ProductService
    {
        public int IdDiplome { get; set; }
        public string Libelle { get; set; }
        public string Niveau { get; set; }

        // Navigation
        public virtual ICollection<Posseder> Certifications { get; set; } = new List<Posseder>();
    }
}