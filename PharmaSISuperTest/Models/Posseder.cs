using System;

namespace PharmaSISuperTest.Models
{
    public class Posseder
    {
        public int IdPraticien { get; set; }
        public int IdDiplome { get; set; }
        public int IdSpecialite { get; set; }
        public decimal? CoefficientPrescription { get; set; }

        // Navigation
        public virtual Praticien Praticien { get; set; }
        public virtual Diplome Diplome { get; set; }
        public virtual Specialite Specialite { get; set; }
    }
}