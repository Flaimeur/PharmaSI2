using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Services
{
    public class PraticienService
    {
        private string connectionString =
            "Server=127.0.0.1;Database=pharmasi;Uid=root;Pwd=;Port=3306";

        public List<dynamic> GetAllPraticiens()
        {
            List<dynamic> praticiens = new List<dynamic>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.idPraticien,
                            p.nom,
                            p.prenom,
                            p.adresse,
                            p.code_postal,
                            p.ville,
                            p.coefficient_notoriete,
                            tp.libelle as type_praticien,
                            s.nom as specialite,
                            d.libelle as diplome,
                            d.niveau,
                            ps.coefficient_prescription
                        FROM praticien p
                        LEFT JOIN praticien_type pt ON p.idPraticien = pt.id_praticien
                        LEFT JOIN type_praticien tp ON pt.id_type = tp.id_type
                        LEFT JOIN posseder ps ON p.idPraticien = ps.id_praticien
                        LEFT JOIN specialite s ON ps.id_specialite = s.id_specialite
                        LEFT JOIN diplome d ON ps.id_diplome = d.id_diplome
                        ORDER BY p.nom, p.prenom
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                praticiens.Add(new
                                {
                                    IdPraticien = Convert.ToInt32(reader["idPraticien"]),
                                    Nom = reader["nom"].ToString(),
                                    Prenom = reader["prenom"].ToString(),
                                    Adresse = reader["adresse"].ToString(),
                                    CodePostal = reader["code_postal"].ToString(),
                                    Ville = reader["ville"].ToString(),
                                    CoefficientNotoriete = Convert.ToDecimal(reader["coefficient_notoriete"]),
                                    Type = reader["type_praticien"] != DBNull.Value ? reader["type_praticien"].ToString() : "",
                                    Specialite = reader["specialite"] != DBNull.Value ? reader["specialite"].ToString() : "",
                                    Diplome = reader["diplome"] != DBNull.Value ? reader["diplome"].ToString() : "",
                                    Niveau = reader["niveau"] != DBNull.Value ? reader["niveau"].ToString() : "",
                                    CoefficientPrescription = reader["coefficient_prescription"] != DBNull.Value ? Convert.ToDecimal(reader["coefficient_prescription"]) : 0
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur récupération praticiens: " + ex.Message);
            }

            return praticiens;
        }
    }
}