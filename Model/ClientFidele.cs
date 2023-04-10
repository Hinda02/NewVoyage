using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{

     public class ClientFidele : Client
    {
        //private double tauxDeReduction = 0;
        public override string Disp { get => base.Disp + "   " + TauxDeReduction + "%"; }

        public ClientFidele(int id, string nom, string prenom, int tel, string adresse, string mail, double tauxDeReduction) 
            :base(id, nom, prenom, tel, adresse, mail)
        {
            this.tauxDeReduction = tauxDeReduction;
        }

        public double TauxDeReduction { get => tauxDeReduction; set => tauxDeReduction = value; }

    }
}
