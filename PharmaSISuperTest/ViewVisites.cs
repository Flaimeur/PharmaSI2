using System;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class ViewVisites : Form
    {
        private VisiteService visiteService;
        private Employee currentEmployee;

        public ViewVisites(Employee employee)
        {
            InitializeComponent();
            visiteService = new VisiteService();
            currentEmployee = employee;
        }

        private void ViewVisites_Load(object sender, EventArgs e)
        {
            LoadRapportsPourListe();
        }

        private void LoadRapportsPourListe()
        {
            try
            {
                var allVisites = visiteService.GetAllVisites();

                // Filtrage selon le Rôle
                var visitesAffichees = allVisites;
                if (currentEmployee.IdPoste == 1) // Visiteur
                {
                    visitesAffichees = allVisites.Where(v => v.EmployeNom == currentEmployee.Nom && v.EmployePrenom == currentEmployee.Prenom).ToList();
                }

                // Formatage pour la liste déroulante
                var displayList = visitesAffichees.Select(v => new
                {
                    Id = v.IdVisite,
                    TexteAffiche = $"Rapport n°{(v.NumeroVisiteEmploye?.ToString() ?? "?")} - Dr. {v.PraticienNom} ({v.DateVisite:dd/MM/yyyy})"
                }).ToList();

                // Injection dans la liste déroulante (ComboBox)
                cbRapports.DataSource = displayList;
                cbRapports.DisplayMember = "TexteAffiche";
                cbRapports.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur au chargement : {ex.Message}", "Erreur");
            }
        }

        // --- BOUTON POUR AFFICHER LES DÉTAILS DANS LE GRAND CARRÉ ---
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (cbRapports.SelectedValue == null) return;

            int selectedId = (int)cbRapports.SelectedValue;
            var visite = visiteService.GetAllVisites().FirstOrDefault(v => v.IdVisite == selectedId);

            if (visite != null)
            {
                string grandTexte = "=== DÉTAILS DU COMPTE-RENDU ===\n\n";

                // Auteur (Caché si c'est l'utilisateur lui-même)
                bool estAuteur = (visite.EmployePrenom == currentEmployee.Prenom && visite.EmployeNom == currentEmployee.Nom);
                if (!estAuteur)
                {
                    grandTexte += $"Auteur : {visite.EmployePrenom} {visite.EmployeNom}\n";
                }

                grandTexte += $"Date de visite : {visite.DateVisite:dd/MM/yyyy}\n";
                grandTexte += $"Praticien : Dr. {visite.PraticienPrenom} {visite.PraticienNom}\n";
                grandTexte += $"Durée : {(visite.DureeVisite > 0 ? visite.DureeVisite.ToString() + " min" : "Non précisée")}\n\n";

                grandTexte += "--- BILAN DE LA VISITE ---\n";
                grandTexte += $"{visite.Rapport}\n\n";

                grandTexte += "--- ÉCHANTILLON OFFERT ---\n";
                if (visite.IdProduit != null)
                {
                    grandTexte += $"Produit Numéro {visite.IdProduit} - Quantité : {visite.QuantiteEchantillon}\n";
                }
                else
                {
                    grandTexte += "Aucun échantillon n'a été offert.\n";
                }

                // On affiche tout le texte
                txtDetails.Text = grandTexte;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            Home homeForm = openForms.OfType<Home>().FirstOrDefault();

            if (homeForm != null)
            {
                homeForm.Show();
            }

            this.Close();
        }

        private void creecompterendu_Click(object sender, EventArgs e)
        {
            Saisie saisie = new Saisie(currentEmployee);
            saisie.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            Home homeForm = openForms.OfType<Home>().FirstOrDefault();

            if (homeForm != null)
            {
                homeForm.Show();
            }

            this.Close();
        }

        private void consultation_Click(object sender, EventArgs e)
        {

        }

        private void praticien_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation(currentEmployee);
            consultation.Show();
            this.Hide();
        }

        private void produitt_Click(object sender, EventArgs e)
        {
            Produit Produit = new Produit();
            Produit.Show();
            this.Hide();
        }

        private void deconexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Ferme TOUTES les fenêtres sauf Login
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is Login))
                    {
                        form.Close();
                    }
                }

                // Affiche Login
                Login login = new Login();
                login.Show();
            }
        }

    }
}