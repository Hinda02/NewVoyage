using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{
  
    public class Voyage
    {
        private int id;
        private string destination;
        private double prix;
        private double taxe;
        private DateTime dateDepart;
        private DateTime dateRetour;
        private int nbPlacesDispos;
        private List<Resa> lReservations = new List<Resa>();

        public Voyage(int id, string destination, double prix, double taxe, DateTime dateDepart, DateTime dateRetour, int nbPlacesDispos)
        {
            this.id = id;
            this.destination = destination;
            this.prix = prix;
            this.taxe = taxe;
            this.dateDepart = dateDepart;
            this.dateRetour = dateRetour;
            this.nbPlacesDispos = nbPlacesDispos;
            
            
        }

        public string Destination { get => destination; set => destination = value; }
        public double Prix { get => prix; set => prix = value; }
        public double Taxe { get => taxe; set => taxe = value; }
        public DateTime DateDepart { get => dateDepart; set => dateDepart = value; }
        public DateTime DateRetour { get => dateRetour; set => dateRetour = value; }
        public int NbPlacesDispos { get => nbPlacesDispos; set => nbPlacesDispos = value; }
        public List<Resa> LReservations { get => lReservations; set => lReservations = value; }
        public int Id { get => id; set => id = value; }

        public void ajouterReservation(Resa reservation)
        {
            this.lReservations.Add(reservation);
        }

        public override string ToString()
        {
            return ("la destination : " + this.destination + " prix : " + this.prix + "taxe : " + this.taxe + "date depart : " + this.dateDepart + "date retour : " + this.dateRetour);
        }

    }
}
