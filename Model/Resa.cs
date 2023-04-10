using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{
  
    public class Resa
    {
        private int id;
        private Voyage leVoyage;
        private Client client;
        private int nbPersonne;
        //private bool confirmation;

        public Resa(int id)
        {
            this.id = id;
        }

        public Resa(Voyage leVoyage, Client client,  int nbPersonne)
        {
            this.leVoyage = leVoyage;
            this.client = client;
            this.nbPersonne = nbPersonne;
            //this.client.ReservationsClient.Add(this);
            //this.confirmation = false;

        }

        /*public Resa(Voyage leVoyage, int nbPersonne)
        {
            this.leVoyage = leVoyage;
            this.nbPersonne = nbPersonne;
        }*/

        public Voyage LeVoyage { get => leVoyage; }
        public int NbPersonne { get => nbPersonne; set => nbPersonne = value; }
        public Client Client { get => client; set => client = value; }
        public string Display { get => LeVoyage.Destination + "   " + LeVoyage.DateDepart.ToShortDateString() + "   " + LeVoyage.DateRetour.ToShortDateString() + "   " + nbPersonne; }
        public int Id { get => id; set => id = value; }

        //public bool Confirmation { get => confirmation; set => confirmation = value; }

        public override string ToString()
        {
            return ("Le montant de la reservation: "+ calculMontant(Client, NbPersonne, LeVoyage)+"€");
        }

        /*public string afficherConfirmation()
        {
            if (confirmation)
            {
                return "confirmée";
            }
            else
            {
                return "annulée";
            }
        }*/

        public string afficher()
        {
            return ("Nom : "+ this.client.Nom + "    Prenom : "+ this.client.Prenom + "    Tel : "+ this.client.Tel + "    Nombre de personnes : " + this.nbPersonne + "    Montant : " + calculMontant(this.Client, this.NbPersonne, this.LeVoyage));
        }

        public static double calculMontant(Client cli, int nbPersonne, Voyage voy)
        {
            //verifier si le client est de type clientFidele
            bool verif = cli.GetType() == typeof(ClientFidele);

            if (verif) //si le client est fidele
            {
                double montant = nbPersonne * (voy.Prix + voy.Taxe);
                double reduction = 1 - (cli.tauxDeReduction / 100);
                return (montant * reduction);
            }
            else //sinon
            {
                double montant = nbPersonne * (voy.Prix + voy.Taxe);
                return montant;
            }
            
        }

        public bool resaPossible()
        {
            if (this.nbPersonne <= this.leVoyage.NbPlacesDispos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void confirmeResa()
        {
            if (this.resaPossible() == true)
            {
                this.leVoyage.NbPlacesDispos -= this.nbPersonne;
            }
        }

    }
}
