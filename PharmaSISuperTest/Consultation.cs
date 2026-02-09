using System;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class Consultation : Form
    {
        private PraticienService praticienService;

        public Consultation()
        {
            InitializeComponent();
            praticienService = new PraticienService();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            LoadPraticiens();
        }

        private void LoadPraticiens()
        {
            try
            {
                var praticiens = praticienService.GetAllPraticiens();

                dataGridViewPraticiens.AutoGenerateColumns = true;
                dataGridViewPraticiens.DataSource = praticiens;
                dataGridViewPraticiens.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void AjusterColonnes()
        {
            if (dataGridViewPraticiens.Columns.Count > 0)
            {
                dataGridViewPraticiens.Columns["Nom"].HeaderText = "Nom";
                dataGridViewPraticiens.Columns["Prenom"].HeaderText = "Prénom";
                dataGridViewPraticiens.Columns["Adresse"].HeaderText = "Adresse";
                dataGridViewPraticiens.Columns["Ville"].HeaderText = "Ville";
                dataGridViewPraticiens.Columns["CodePostal"].HeaderText = "Code Postal";
                dataGridViewPraticiens.Columns["Type"].HeaderText = "Type";
                dataGridViewPraticiens.Columns["Specialite"].HeaderText = "Spécialité";
                dataGridViewPraticiens.Columns["Diplome"].HeaderText = "Diplôme";
                dataGridViewPraticiens.Columns["Niveau"].HeaderText = "Niveau";
                dataGridViewPraticiens.Columns["CoefficientNotoriete"].HeaderText = "Coefficient Notoriété";
                dataGridViewPraticiens.Columns["CoefficientPrescription"].HeaderText = "Coefficient Prescription";
            }
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

        private void produitt_Click(object sender, EventArgs e)
        {
            Produit Produit = new Produit();
            Produit.Show();
            this.Close();
        }
    }
}