using System;
using System.Linq;
using System.Windows.Forms;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;

namespace PharmaSISuperTest
{
    public partial class Saisie : Form
    {
        private VisiteService visiteService;
        private Employee currentEmployee;

        public Saisie(Employee employee)
        {
            InitializeComponent();
            visiteService = new VisiteService();
            currentEmployee = employee;
        }

        private void Saisie_Load(object sender, EventArgs e)
        {
            LoadPraticiens();
        }

        private void LoadPraticiens()
        {
            try
            {
                PraticienService praticienService = new PraticienService();
                var praticiens = praticienService.GetAllPraticiens();

                comboBoxPraticien.DataSource = praticiens;
                comboBoxPraticien.DisplayMember = "Prenom";  
                comboBoxPraticien.ValueMember = "Nom"; 
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

        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxRapport.Text))
                {
                    MessageBox.Show("Le rapport est obligatoire.", "Validation");
                    return;
                }

                dynamic selectedPraticien = comboBoxPraticien.SelectedItem as dynamic;
                int idPraticien = selectedPraticien.IdPraticien ?? 1;

                int dureeMinutes = 0;

                if (!string.IsNullOrWhiteSpace(textBoxDuree.Text))
                {
                    string[] parts = textBoxDuree.Text.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int h) && int.TryParse(parts[1], out int m))
                    {
                        dureeMinutes = (h * 60) + m;
                    }
                }

                Visite visite = new Visite
                {
                    IdEmploye = currentEmployee.IdEmploye,
                    IdPraticien = idPraticien,
                    DateVisite = dateTimePickerVisite.Value,
                    Rapport = textBoxRapport.Text,
                    DureeVisite = dureeMinutes > 0 ? dureeMinutes : (int?)null
                };

                if (visiteService.SaveVisite(visite))
                {
                    MessageBox.Show("Visite sauvegardée avec succès !", "Succès");
                    textBoxRapport.Clear();
                    textBoxDuree.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur");
            }
        }

        private void buttonRetour_Click_1(object sender, EventArgs e)
        {

        }
    }
}