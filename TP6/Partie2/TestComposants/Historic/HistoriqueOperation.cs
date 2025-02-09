using ComposantCalcul;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Historic
{
    public class HistoriqueOperation : IHistory
    {
        private string connectionString = "Data Source=localhost:1521/XE; User Id=system; Password=system;";

        public void SauvegarderOperation(string operation, string resultat)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Historique_Operations (Operation, Resultat, DateOperation) VALUES (:operation, :resultat, :DateOperation)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("operation", operation));
                    cmd.Parameters.Add(new OracleParameter("resultat", resultat));
                    cmd.Parameters.Add(new OracleParameter("DateOperation", DateTime.Today));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> AfficherHistorique()
        {
            List<string> historique = new List<string>();
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Operation, Resultat, DateOperation FROM Historique_Operations ORDER BY DateOperation DESC";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string entry = $"{reader["Operation"]} = {reader["Resultat"]}";
                            historique.Add(entry);
                        }
                    }
                }
            }
            return historique;
        }
    }
}
