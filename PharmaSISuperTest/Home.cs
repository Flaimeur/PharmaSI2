using System;
using System.Windows.Forms;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest
{
    public partial class Home : Form
    {
        private Employee currentEmployee;

        public Home(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DisplayUserInfo();
            ConfigureMenusByRole();
        }

        private void DisplayUserInfo()
        {
            statusLabel.Text = "";
            if (currentEmployee != null)
            {
                string role = GetRoleName(currentEmployee.IdPoste);
                statusLabel.Text = $"Bonjour {currentEmployee.Prenom}👋\nStatut : {role}";
            }
        }



        private string GetRoleName(int? idPoste)
        {
            if (!idPoste.HasValue)
                return "";

            switch (idPoste.Value)
            {
                case 1:
                    return "Visiteur";
                case 2:
                    return "Responsable";
                case 3:
                    return "Délégué";
                default:
                    return "";
            }
        }

        private void ConfigureMenusByRole()
        {
            if (currentEmployee?.IdPoste == null)
                return;

            int role = currentEmployee.IdPoste.Value;
            masquerTousLesMenus();

            switch (role)
            {
                case 1:
                    afficherMenusVisiteur();
                    break;
                case 2:
                    afficherMenusResponsable();
                    break;
                case 3:
                    afficherMenusDelegue();
                    break;
                default:
                    MessageBox.Show("Rôle non reconnu.", "Erreur");
                    break;
            }
        }

        private void masquerTousLesMenus()
        {
            // À adapter selon les noms de menus
        }

        private void afficherMenusVisiteur()
        {
            // Consultation, Saisie
        }

        private void afficherMenusResponsable()
        {
            // Consultation, Produit
        }

        private void afficherMenusDelegue()
        {
            // Tous les menus
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consultation - Sprint 3", "Info");
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saisie Visite - Sprint 5", "Info");
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestion Produits - Sprint 4", "Info");
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
                this.Close();

            }
        }

        private void praticien_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();
            consultation.Show();
            this.Hide();
        }

        private void produitt_Click(object sender, EventArgs e)
        {
            Produit Produit = new Produit();
            Produit.Show();
            this.Hide();
        }
    }
}