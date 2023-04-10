using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewVoyage
{

    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private int tel;
        private string adresse;
        private string mail;
        public double tauxDeReduction = 0;
        private List<Resa> reservationsClient = new List<Resa>();

        public Client(string nom, string prenom, int tel, string adresse, string mail)
        {

            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
            this.mail = mail;

        }

        public Client(int id, string nom, string prenom, int tel, string adresse, string mail)
        {

            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
            this.mail = mail;
            
        }

        public Client(int id, string nom, string prenom, int tel, string adresse, string mail, double taux)
        {

            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.adresse = adresse;
            this.mail = mail;
            this.tauxDeReduction = taux;

        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }
        public virtual string Disp { get => Nom + "   " + Prenom + "   " + Adresse; }
        public List<Resa> ReservationsClient { get => reservationsClient; set => reservationsClient = value; }
        

        public void ajouterReservation(Resa reservation)
        {
            this.reservationsClient.Add(reservation);
        }

        public void listeReservation(ListBox liste)
        {
            if(reservationsClient != null)
            {
                liste.DataSource = reservationsClient;
                liste.DisplayMember = "NbPersonne";
            }
            else
            {
                liste.DataSource = null;
            }
        }

    }
}
