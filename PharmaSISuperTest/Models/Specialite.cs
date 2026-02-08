using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Specialite
    {
        public int IdSpecialite { get; set; }
        public string Nom { get; set; }

        // Navigation
        public virtual ICollection<Posseder> Certifications { get; set; } = new List<Posseder>();
    }
}