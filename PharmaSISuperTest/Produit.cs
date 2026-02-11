using System;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class Produit : Form
    {
        private ProductService productService;
        private Employee currentEmployee;

        public Produit()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                var products = productService.GetAllProduct();
                dataGridViewProduct.AutoGenerateColumns = true;
                dataGridViewProduct.DataSource = products;
                dataGridViewProduct.ReadOnly = true;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void praticien_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation(currentEmployee);
            consultation.Show();
            this.Hide();
        }

        private void creecompterendu_Click(object sender, EventArgs e)
        {
            Saisie saisie = new Saisie(currentEmployee);
            saisie.Show();
            this.Hide();
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
    }
}