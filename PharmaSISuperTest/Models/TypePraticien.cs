using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class TypePraticien
    {
        public int IdType { get; set; }
        public string Libelle { get; set; }

        // Navigation
        public virtual ICollection<Praticien> Praticiens { get; set; } = new List<Praticien>();
    }
}