using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace RemotingInterfaces
{
    public interface IRemoteOperation
    {
        void Connect();
        void AjouterUnCours(int code, string designantion, int volume, string category);
        DataTable GetData(string tableName);
        void AjouterUnEnseigant(int matricule, string nom, string prenom, string telephone, int experience, string grade, string email);
        int CompterEnseigne();
        void AjouterUnEnseigne(int matricule, int code);
        void Supprimer(string table, int id);
        DataTable Join();
        void SupprimerEnseigne(int code, int matricule);
    }
}