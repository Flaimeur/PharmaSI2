using System;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Controllers;

namespace PharmaSISuperTest
{
    public partial class Login : Form
    {
        private readonly LoginController _controller;

        public Login()
        {
            InitializeComponent();
            _controller = new LoginController(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIdentifiant.Focus();
            textBoxMotDePasse.UseSystemPasswordChar = true;
        }

        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            // Call the controller to handle login logic
            _controller.Authenticate(textBoxIdentifiant.Text.Trim(), textBoxMotDePasse.Text);
        }

        // --- Methods called by the Controller (Public for access from Controller) ---

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ClearAndFocus()
        {
            textBoxIdentifiant.Clear();
            textBoxMotDePasse.Clear();
            textBoxIdentifiant.Focus();
        }

        public void NavigateToHome(Employee employee)
        {
            Home homeForm = new Home(employee);
            homeForm.Show();
        }

        public void HideView()
        {
            this.Hide();
        }
    }
}