using System;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class Saisie : Form
    {
        private VisiteService visiteService;
        private Employee currentEmployee;

        public Saisie(Employee employee)
        {
            InitializeComponent();
            visiteService = new VisiteService();
            currentEmployee = employee;
        }

        private void Saisie_Load(object sender, EventArgs e)
        {
            LoadPraticiens();
            LoadProduits();
        }

        private void LoadProduits()
        {
            try
            {
                ProductService productService = new ProductService();
                var produits = productService.GetAllProduct(); // Récupère la liste depuis votre service

                cbProduits.DataSource = produits;
                cbProduits.DisplayMember = "NumeroDuProduit"; // Ce qui est affiché dans la liste
                cbProduits.ValueMember = "IdProduit";         // La valeur technique utilisée pour la BDD
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement produits : {ex.Message}");
            }
        }

        private void LoadPraticiens()
        {
            try
            {
                PraticienService praticienService = new PraticienService();
                var praticiens = praticienService.GetAllPraticiens();

                comboBoxPraticien.DataSource = praticiens;
                comboBoxPraticien.DisplayMember = "Prenom";  
                comboBoxPraticien.ValueMember = "Nom"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validation du rapport
                if (string.IsNullOrWhiteSpace(textBoxRapport.Text))
                {
                    MessageBox.Show("Le rapport est obligatoire.", "Validation");
                    return;
                }

                // 2. Récupération du Praticien
                dynamic selectedPraticien = comboBoxPraticien.SelectedItem as dynamic;
                int idPraticien = selectedPraticien.IdPraticien ?? 1;

                // 3. Calcul de la durée
                int dureeMinutes = 0;
                if (!string.IsNullOrWhiteSpace(textBoxDuree.Text))
                {
                    string[] parts = textBoxDuree.Text.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int h) && int.TryParse(parts[1], out int m))
                    {
                        dureeMinutes = (h * 60) + m;
                    }
                }

                // --- NOUVEAU : Récupération de l'échantillon ---
                int? idProduitChoisi = null;
                int quantiteChoisie = 0;

                // On vérifie si un produit est sélectionné dans la liste cbProduits
                if (cbProduits.SelectedValue != null)
                {
                    idProduitChoisi = Convert.ToInt32(cbProduits.SelectedValue);
                    // On récupère la valeur du NumericUpDown (nudQuantite)
                    quantiteChoisie = (int)nudQuantite.Value;
                }

                // 4. Création de l'objet Visite avec les nouvelles colonnes
                Visite visite = new Visite
                {
                    IdEmploye = currentEmployee.IdEmploye,
                    IdPraticien = idPraticien,
                    DateVisite = dateTimePickerVisite.Value,
                    Rapport = textBoxRapport.Text,
                    DureeVisite = dureeMinutes > 0 ? dureeMinutes : (int?)null,

                    // On ajoute les infos d'échantillon ici
                    IdProduit = idProduitChoisi,
                    QuantiteEchantillon = quantiteChoisie > 0 ? quantiteChoisie : (int?)null
                };

                // 5. Sauvegarde
                if (visiteService.SaveVisite(visite))
                {
                    MessageBox.Show("Visite et échantillon sauvegardés avec succès !", "Succès");

                    // Nettoyage des champs
                    textBoxRapport.Clear();
                    textBoxDuree.Clear();
                    nudQuantite.Value = 0;
                    cbProduits.SelectedIndex = -1; // Remet la liste à zéro
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void voircompterendu_Click(object sender, EventArgs e)
        {
            ViewVisites viewVisites = new ViewVisites(currentEmployee);
            viewVisites.Show();
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

        private void buttonRetour_Click_1(object sender, EventArgs e)
        {
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            Home homeForm = openForms.OfType<Home>().FirstOrDefault();

            if (homeForm != null)
            {
                homeForm.Show();
            }

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}