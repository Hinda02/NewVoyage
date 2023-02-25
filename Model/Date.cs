using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{
  
    public class Date
    {
        //attributs prives
        private int jour;
        private int mois;
        private int annee;

        public Date(int jour, int mois, int annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
        }

        public int Jour { get => jour; set => jour = value; }
        public int Mois { get => mois; set => mois = value; }
        public int Annee { get => annee; set => annee = value; }

        public override string ToString()
        {
            return (jour + "/ " + mois + "/ " + annee);
        }

    }
}
