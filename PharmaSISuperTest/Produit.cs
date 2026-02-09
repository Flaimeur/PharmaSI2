using System;
using System.Windows.Forms;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class Produit : Form
    {
        private ProductService productService;

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
                MessageBox.Show($"Produits trouvés : {products.Count}", "Debug");
                dataGridViewProduct.AutoGenerateColumns = true;
                dataGridViewProduct.DataSource = products;
                dataGridViewProduct.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                this.Close();
        }

    }
}