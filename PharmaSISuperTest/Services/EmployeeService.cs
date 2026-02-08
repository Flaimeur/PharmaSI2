using System;
using MySql.Data.MySqlClient;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Services
{
    public class EmployeeService
    {
        private string connectionString = "Server=127.0.0.1;Database=pharmasi;Uid=root;Pwd=;Port=3306";

        public Employee AuthenticateEmployee(string mail, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT id_employe, nom, prenom, mail, id_poste FROM employe WHERE mail = @mail AND mdp = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mail", mail);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employee emp = new Employee
                                {
                                    IdEmploye = Convert.ToInt32(reader["id_employe"]),
                                    Nom = reader["nom"].ToString(),
                                    Prenom = reader["prenom"].ToString(),
                                    Mail = reader["mail"].ToString(),
                                    IdPoste = Convert.ToInt32(reader["id_poste"]),
                                    Poste = new Poste { IdPoste = Convert.ToInt32(reader["id_poste"]), Libelle = "User" }
                                };
                                return emp;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur authentication: " + ex.Message);
            }

            return null;
        }
    }
}