using System;
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
                dataGridViewPraticiens.DataSource = praticiens;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
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
    }
}