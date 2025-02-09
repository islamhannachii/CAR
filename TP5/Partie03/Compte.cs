using System.Data.Linq.Mapping;
namespace Partie03
{
    [Table(Name = "Comptes")]
    internal class Compte
    {

        private int id;
        private double solde;
        [Column(IsPrimaryKey = true)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Column]
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
    }


}
