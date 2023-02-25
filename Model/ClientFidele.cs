using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{

     public class ClientFidele : Client
    {
        public override string Disp { get => base.Disp + "   " + TauxDeReduction + "%"; }

        public ClientFidele(string nom, string prenom, int tel, string adresse, string mail, double tauxDeReduction) 
            :base(nom, prenom, tel, adresse, mail)
        {
            this.tauxDeReduction = tauxDeReduction;
        }

        public double TauxDeReduction { get => tauxDeReduction; set => tauxDeReduction = value; }

    }
}
