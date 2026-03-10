using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Services
{
    public class VisiteService
    {
        private string connectionString =
            "Server=127.0.0.1;Database=pharmasi;Uid=root;Pwd=;Port=3306";

        public bool SaveVisite(Visite visite)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO visite (
                    id_employe, 
                    idPraticien, 
                    dateVisite, 
                    rapport, 
                    duree_visite, 
                    idProduit, 
                    quantite_echantillon
                    ) 
                    VALUES (
                    @idEmploye, 
                    @idPraticien, 
                    @dateVisite, 
                    @rapport, 
                    @dureeVisite, 
                    @idProd, 
                    @qte
                    )
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEmploye", visite.IdEmploye);
                        cmd.Parameters.AddWithValue("@idPraticien", visite.IdPraticien);
                        cmd.Parameters.AddWithValue("@dateVisite", visite.DateVisite);
                        cmd.Parameters.AddWithValue("@rapport", visite.Rapport);
                        cmd.Parameters.AddWithValue("@dureeVisite", visite.DureeVisite ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@idProduit", visite.IdProduit ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@quantiteEchantillon", visite.QuantiteEchantillon ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@idProd", visite.IdProduit ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@qte", visite.QuantiteEchantillon ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur sauvegarde visite: " + ex.Message);
            }
        }

        public List<dynamic> GetAllVisites()
        {
            List<dynamic> visites = new List<dynamic>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            v.idVisite,
                            v.numero_visite_employe,
                            e.prenom as employe_prenom,
                            e.nom as employe_nom,
                            p.prenom as praticien_prenom,
                            p.nom as praticien_nom,
                            v.dateVisite,
                            v.rapport,
                            v.duree_visite,
                            v.date_creation,
                            v.idProduit,
                            v.quantite_echantillon
                        FROM visite v
                        LEFT JOIN employe e ON v.id_employe = e.id_employe
                        LEFT JOIN praticien p ON v.idPraticien = p.idPraticien
                        ORDER BY v.dateVisite DESC
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                visites.Add(new
                                {
                                    IdVisite = Convert.ToInt32(reader["idVisite"]),
                                    EmployePrenom = reader["employe_prenom"].ToString(),
                                    EmployeNom = reader["employe_nom"].ToString(),
                                    PraticienPrenom = reader["praticien_prenom"].ToString(),
                                    PraticienNom = reader["praticien_nom"].ToString(),
                                    DateVisite = Convert.ToDateTime(reader["dateVisite"]),
                                    Rapport = reader["rapport"].ToString(),
                                    DureeVisite = reader["duree_visite"] != DBNull.Value ? Convert.ToInt32(reader["duree_visite"]) : 0,
                                    DateCreation = Convert.ToDateTime(reader["date_creation"]),
                                    NumeroVisiteEmploye = reader["numero_visite_employe"] != DBNull.Value ? Convert.ToInt32(reader["numero_visite_employe"]) : (int?)null,
                                    IdProduit = reader["idProduit"] != DBNull.Value ? Convert.ToInt32(reader["idProduit"]) : (int?)null,
                                    QuantiteEchantillon = reader["quantite_echantillon"] != DBNull.Value ? Convert.ToInt32(reader["quantite_echantillon"]) : (int?)null
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur récupération visites: " + ex.Message);
            }

            return visites;
        }
    }
}