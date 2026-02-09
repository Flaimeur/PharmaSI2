using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PharmaSISuperTest.Models;

namespace PharmaSISuperTest.Services
{
    public class ProductService
    {
        private string connectionString =
            "Server=127.0.0.1;Database=pharmasi;Uid=root;Pwd=;Port=3306";

        public List<dynamic> GetAllProduct()
        {
            List<dynamic> products = new List<dynamic>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    p.IdProduit,
                    p.NumeroDuProduit,
                    p.PrixEchantillon,
                    p.EffetsTherapeutiques,
                    p.Contre_indications,
                    p.Interactions,
                    f.nom as Famille,
                    c.libelle as Composant
                FROM produit p
                LEFT JOIN appartenir ap ON p.IdProduit = ap.IdProduit
                LEFT JOIN famille f ON ap.idFamille = f.idFamille
                LEFT JOIN composer co ON p.IdProduit = co.IdProduit
                LEFT JOIN composant c ON co.idComposant = c.idComposant
                ORDER BY p.NumeroDuProduit
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(new
                                {
                                    NumeroDuProduit = reader["NumeroDuProduit"].ToString(),
                                    PrixEchantillon = Convert.ToDecimal(reader["PrixEchantillon"]),
                                    EffetsTherapeutiques = reader["EffetsTherapeutiques"].ToString(),
                                    ContreIndications = reader["Contre_indications"].ToString(),
                                    Interactions = reader["Interactions"].ToString(),
                                    Famille = reader["Famille"] != DBNull.Value ? reader["Famille"].ToString() : "",
                                    Composant = reader["Composant"] != DBNull.Value ? reader["Composant"].ToString() : ""
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur récupération produits: " + ex.Message);
            }

            return products;
        }
    }
}