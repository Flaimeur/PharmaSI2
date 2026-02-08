using System;
using System.Data.Entity;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Data
{
    public class PharmaSIContext : DbContext
    {
        public PharmaSIContext() : base("PharmaSIConnection")
        {
        }

        public DbSet<Employee> Employes { get; set; }
        public DbSet<Poste> Postes { get; set; }
        public DbSet<Product> Produits { get; set; }
        public DbSet<Famille> Familles { get; set; }
        public DbSet<Composant> Composants { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<TypePraticien> TypePraticiens { get; set; }
        public DbSet<Diplome> Diplomes { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Posseder> Posseder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}