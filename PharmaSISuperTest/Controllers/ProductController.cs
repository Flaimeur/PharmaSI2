using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;
using PharmaSISuperTest.Views;

namespace PharmaSISuperTest.Controllers
{
    public class ProductController
    {
        private readonly Produit _view;
        private readonly ProductService _service;
        private readonly Employee _currentEmployee;

        public ProductController(Produit view, Employee employee)
        {
            _view = view;
            _service = new ProductService();
            _currentEmployee = employee;
        }

        public void LoadProducts()
        {
            try
            {
                var products = _service.GetAllProduct();
                _view.DisplayProducts(products);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Erreur : {ex.Message}");
            }
        }

        public void GoBack()
        {
            Form[] openForms = Application.OpenForms.OfType<Form>().ToArray();
            Home homeForm = openForms.OfType<Home>().FirstOrDefault();

            if (homeForm != null)
            {
                homeForm.Show();
            }

            _view.CloseView();
        }

        public void OpenConsultation()
        {
            Consultation consultation = new Consultation(_currentEmployee);
            consultation.Show();
            _view.HideView();
        }

        public void OpenSaisie()
        {
            Saisie saisie = new Saisie(_currentEmployee);
            saisie.Show();
            _view.HideView();
        }

        public void OpenViewVisites()
        {
            ViewVisites viewVisites = new ViewVisites(_currentEmployee);
            viewVisites.Show();
            _view.HideView();
        }

        public void Logout()
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
