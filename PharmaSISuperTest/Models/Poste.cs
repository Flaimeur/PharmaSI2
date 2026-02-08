using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Poste
    {
        public int IdPoste { get; set; }
        public string Libelle { get; set; }

        // Navigation
        public virtual ICollection<Employee> Employes { get; set; } = new List<Employee>();
    }
}
