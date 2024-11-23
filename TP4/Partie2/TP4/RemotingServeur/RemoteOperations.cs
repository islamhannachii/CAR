using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using RemotingInterfaces;

namespace RemotingServeur
{
    public class RemoteOperation : MarshalByRefObject,
     RemotingInterfaces.IRemoteOperation
    {


        //private double nomre = 0;
        private static string SQL;
        private static OracleConnection conn;
        private static OracleCommand cmd;
        private static OracleDataAdapter da;
        private static DataSet ds;
        /*-------------------------------------------------------------------*/
        // Indique que l'objet aura une durée de vie illimitée
        public override object InitializeLifetimeService()
        {
            return null;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Division

         void IRemoteOperation.AjouterUnCours(int code, string designation, int volume, string category)
            {
                Console.WriteLine("Ajouter en cours ...");
                //Console.WriteLine("Ajouter en cours ...");

            try
                {
                using (OracleCommand cmd = new OracleCommand("INSERT INTO COURS (CODE, DESIGNATION, VOLUME, CATEGORIE) VALUES(:code, :designation, :volume, :CATEGORIE)", conn))
                {
                    // Adding parameters with correct data types
                    cmd.Parameters.Add(new OracleParameter("code", code));
                    cmd.Parameters.Add(new OracleParameter("designation", designation));
                    cmd.Parameters.Add(new OracleParameter("volume", (volume))); 
                    cmd.Parameters.Add(new OracleParameter("CATEGORIE", category));

                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("l'ajout a ete effecute avec succes");
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.ToString());
                }

            }
               
         void IRemoteOperation.AjouterUnEnseigant(int matricule, string nom, string prenom, string telephone, int experience, string grade, string email) {

            Console.WriteLine("L'ajout en cours ...");
            try
            {
                using (OracleCommand cmd = new OracleCommand("INSERT INTO Enseignant VALUES(:matricule, :nom, :prenom, :telephone, :email, :experience, :grade)", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("matricule", matricule));
                    cmd.Parameters.Add(new OracleParameter("nom", nom));
                    cmd.Parameters.Add(new OracleParameter("prenom", prenom));
                    cmd.Parameters.Add(new OracleParameter("telephone", telephone));
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("experience", experience));
                    cmd.Parameters.Add(new OracleParameter("grade", grade));
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Enseignant ajoute");
            }
            catch (OracleException ex)
            {
                Console.Error.WriteLine("Oracle error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("General error: " + e.ToString());
            }
        }

        DataTable IRemoteOperation.GetData(string tableName)
        {
            string cmdQuery = "SELECT * FROM "+tableName;
            OracleDataAdapter myAdapter = new OracleDataAdapter(cmdQuery, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "TableOracle");
            DataView dvSample = ds.Tables["TableOracle"].DefaultView;
            DataTable tableToSerialize = dvSample.ToTable();
            return tableToSerialize;
        }

        void IRemoteOperation.Supprimer(string table, int id)
        {

            if (table == "enseignant")
            {
                SQL = "DELETE FROM enseignant WHERE matricule = :id";
            }
            else
            {
                SQL = $"DELETE FROM {table} WHERE code = :id"; // Dynamic but controlled table name
            }

            try
            {
                using (var cmd = new OracleCommand(SQL, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("id", id)); // Use parameterized query
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        Console.WriteLine("Enregistrement supprimé avec succès...");
                    }
                    else
                    {
                        Console.WriteLine("Enregistrement introuvable...");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur: " + e.Message);
            }

        }
        void IRemoteOperation.SupprimerEnseigne(int code, int matricule)
        {
            try
            {
                SQL = "DELETE FROM enseigne WHERE matricule = :matricule AND code = :code";
                using (var cmd = new OracleCommand(SQL, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("code", code)); // Use parameterized query
                    cmd.Parameters.Add(new OracleParameter("matricule", matricule)); // Use parameterized query
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        Console.WriteLine("Enregistrement supprimé avec succès...");
                    }
                    else
                    {
                        Console.WriteLine("Enregistrement introuvable...");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur: " + e.Message);
            }
        }

        void IRemoteOperation.Connect()
        {
            try
            {
                //string oradb = "Data Source= 192.168.213.137:1522 ; User Id=pedagogieuser; Password= admin;";
                string oradb = "Data Source= XE; User Id=system; Password= system;";

                conn = new OracleConnection(oradb);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        int IRemoteOperation.CompterEnseigne()
        {
            string cmdQuery = "Select count(*) FROM Enseigne;";
            OracleDataAdapter myAdapter = new OracleDataAdapter(cmdQuery, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "TableOracle");
            DataView dvSample = ds.Tables["TableOracle"].DefaultView;
            DataTable tableToSerialize = dvSample.ToTable();
            //Console.WriteLine();
            return Convert.ToInt32(tableToSerialize.Rows[0][0]);
        }

        void IRemoteOperation.AjouterUnEnseigne(int matricule, int code)
        {
            try
            {
                Console.WriteLine("Adding Enseigne: matricule: " + matricule + " code: "+code);
                using (OracleCommand cmd = new OracleCommand("INSERT INTO Enseigne VALUES(:code,:matricule)", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("matricule", matricule));
                    cmd.Parameters.Add(new OracleParameter("code", code));
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Enseigne ajoute");
            }
            catch (OracleException ex)
            {
                Console.Error.WriteLine("Oracle error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("General error: " + e.ToString());
            }
        }

        DataTable IRemoteOperation.Join()
        {
            //string cmdQuery = "SELECT designation, nom, prenom FROM cours, enseignant, enseigne WHERE enseigne.code = cours.code AND enseignant.matricule = enseigne.matricule;";
            string cmdQuery = @"
                SELECT c.designation, e.nom, e.prenom
                FROM enseigne en
                INNER JOIN cours c ON en.code = c.code
                INNER JOIN enseignant e ON e.matricule = en.matricule";

            OracleDataAdapter myAdapter = new OracleDataAdapter(cmdQuery, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "TableOracle");
            DataView dvSample = ds.Tables["TableOracle"].DefaultView;
            DataTable tableToSerialize = dvSample.ToTable();
            return tableToSerialize;
        }
    }
    }
