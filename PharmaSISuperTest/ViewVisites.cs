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
            LoadVisites();
        }

        private void LoadVisites()
        {
            try
            {
                var visites = visiteService.GetAllVisites();

                if (currentEmployee.IdPoste == 1)
                {  // Visiteur
                    visites = visites.FindAll(v => v.EmployePrenom == currentEmployee.Prenom && v.EmployeNom == currentEmployee.Nom);
                }

                dataGridViewVisites.AutoGenerateColumns = true;
                dataGridViewVisites.DataSource = visites;
                dataGridViewVisites.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
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