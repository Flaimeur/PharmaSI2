using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Controllers;

namespace PharmaSISuperTest.Views
{
    public partial class Produit : Form
    {
        private readonly ProductController _controller;

        public Produit(Employee employee)
        {
            InitializeComponent();
            _controller = new ProductController(this, employee);
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            _controller.LoadProducts();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            _controller.GoBack();
        }

        private void praticien_Click(object sender, EventArgs e)
        {
            _controller.OpenConsultation();
        }

        private void creecompterendu_Click(object sender, EventArgs e)
        {
            _controller.OpenSaisie();
        }

        private void voircompterendu_Click(object sender, EventArgs e)
        {
            _controller.OpenViewVisites();
        }

        private void deconexion_Click(object sender, EventArgs e)
        {
            _controller.Logout();
        }

        // --- Methods called by the Controller ---

        public void DisplayProducts(List<Product> products)
        {
            dataGridViewProduct.AutoGenerateColumns = true;
            dataGridViewProduct.DataSource = products;
            dataGridViewProduct.ReadOnly = true;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CloseView()
        {
            this.Close();
        }

        public void HideView()
        {
            this.Hide();
        }
    }
}