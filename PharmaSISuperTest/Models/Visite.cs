using System;
using System.Collections.Generic;
using System.Linq;
using PharmaSISuperTest.Data;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Models
{
    public class Visite
    {
        public int IdVisite { get; set; }
        public int IdEmploye { get; set; }
        public int IdPraticien { get; set; }
        public DateTime DateVisite { get; set; }
        public string Rapport { get; set; }
        public int? DureeVisite { get; set; }
        public DateTime DateCreation { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Praticien Praticien { get; set; }

        public int? NumeroVisiteEmploye { get; set; }
        public int? IdProduit { get; set; }
        public int? QuantiteEchantillon { get; set; }
    }
}