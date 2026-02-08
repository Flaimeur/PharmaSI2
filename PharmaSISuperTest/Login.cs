using System;
using System.Windows.Forms;
using PharmaSISuperTest.Models;      
using PharmaSISuperTest.Services;   
using PharmaSISuperTest.Helpers;    

namespace PharmaSISuperTest
{
    public partial class Login : Form
    {
        private EmployeeService employeeService;

        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIdentifiant.Focus();
            textBoxMotDePasse.UseSystemPasswordChar = true;
        }

        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIdentifiant.Text.Trim();
            string motDePasse = textBoxMotDePasse.Text;

            if (string.IsNullOrWhiteSpace(identifiant))
            {
                MessageBox.Show("Le champ identifiant doit être renseigné.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxIdentifiant.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Le champ mot de passe doit être renseigné.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMotDePasse.Focus();
                return;
            }

            AuthenticateUser(identifiant, motDePasse);
        }

        private void AuthenticateUser(string email, string password)
        {
            try
            {
                string hashedPassword = SecurityHelper.HashPassword(password);
                Employee employee = employeeService.AuthenticateEmployee(email, hashedPassword);
                if (employee == null)
                {
                    MessageBox.Show("Erreur login/mot de passe. Connexion impossible !",
                        "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                    return;
                }

                if (!IsUserRoleAllowed(employee))
                {
                    MessageBox.Show($"Bonjour {employee.Prenom}, vous êtes {employee.Poste.Libelle} et ne pouvez vous connecter.",
                        "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                    return;
                }

                DisplaySuccessMessage(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur connexion : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUserRoleAllowed(Employee employee)
        {
            if (!employee.IdPoste.HasValue)
                return false;

            return employee.IdPoste >= 1 && employee.IdPoste <= 3;
        }

        private void DisplaySuccessMessage(Employee employee)
        {
            Home homeForm = new Home(employee);
            homeForm.Show();  

            this.Hide();
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxIdentifiant.Clear();
            textBoxMotDePasse.Clear();
            textBoxIdentifiant.Focus();
        }
    }
}