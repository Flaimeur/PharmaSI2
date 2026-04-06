using System;
using PharmaSISuperTest.Models;
using PharmaSISuperTest.Services;
using PharmaSISuperTest.Helpers;

namespace PharmaSISuperTest.Controllers
{
    public class LoginController
    {
        private readonly Login _view;
        private readonly EmployeeService _service;

        public LoginController(Login view)
        {
            _view = view;
            _service = new EmployeeService();
        }

        public void Authenticate(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                _view.ShowErrorMessage("Le champ identifiant doit être renseigné.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                _view.ShowErrorMessage("Le champ mot de passe doit être renseigné.");
                return;
            }

            try
            {
                string hashedPassword = SecurityHelper.HashPassword(password);
                Employee employee = _service.AuthenticateEmployee(email, hashedPassword);

                if (employee == null)
                {
                    _view.ShowErrorMessage("Erreur login/mot de passe. Connexion impossible !");
                    _view.ClearAndFocus();
                    return;
                }

                if (!IsUserRoleAllowed(employee))
                {
                    _view.ShowErrorMessage($"Bonjour {employee.Prenom}, vous êtes {employee.Poste.Libelle} et ne pouvez vous connecter.");
                    _view.ClearAndFocus();
                    return;
                }

                _view.NavigateToHome(employee);
                _view.HideView();
                _view.ClearAndFocus();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage($"Erreur connexion : {ex.Message}");
            }
        }

        private bool IsUserRoleAllowed(Employee employee)
        {
            if (!employee.IdPoste.HasValue)
                return false;

            // Rôles autorisés (1 à 3 dans l'exemple actuel)
            return employee.IdPoste >= 1 && employee.IdPoste <= 3;
        }
    }
}
