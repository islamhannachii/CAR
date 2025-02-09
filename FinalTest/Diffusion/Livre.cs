using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diffusion
{
    public class Livre
    {
        public int code, matricule,annee;
        public string titre, langue; 

        public int Code {  get; set; } 
        public int Matricule {  get; set; }    
        public int Annee {  get; set; }    
        public String Titre {  get; set; } 
        public String Langue { get; set; }    

    }
}
