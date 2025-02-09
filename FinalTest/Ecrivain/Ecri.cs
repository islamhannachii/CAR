using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Diffusion;
using Oracle.DataAccess.Client;
namespace Ecrivain
{
    public class Ecri : IPub
    {
        private string connectionString = "Data Source=localhost:1521/XE; User Id=system; Password=system;";
        public void insererLivre(Diffusion.Livre livre)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Livre (code, matricule, annee, titre, langue) VALUES (:code, :matricule, :annee, :titre, :langue)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("code",livre.Code));
                    cmd.Parameters.Add(new OracleParameter("matricule", livre.Matricule));
                    cmd.Parameters.Add(new OracleParameter("annee", livre.Annee));
                    cmd.Parameters.Add(new OracleParameter("titre", livre.Titre));
                    cmd.Parameters.Add(new OracleParameter("langue", livre.Langue));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void insererEcrivain(Diffusion.Ecrivain e)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Ecrivain (matricule, nom, prenom) VALUES (:matricule, :nom, :prenom)";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("matricule", e.Matricule));
                    cmd.Parameters.Add(new OracleParameter("nom", e.Nom));
                    cmd.Parameters.Add(new OracleParameter("prenom", e.Prenom));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AfficherCatalogue(string path)
        {
            throw new NotImplementedException();
        }

        public void AjouterCatalogue(XElement e, string path)
        {
            throw new NotImplementedException();
        }
    }
}
