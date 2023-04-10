using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewVoyage.Controller;
using NewVoyage.DAL;

namespace NewVoyage
{
    public partial class FormResa : Form
    {
        private Resa reservation1;

        private Voyage v;

        //private List<Client> clients = ClientController.getAll();

        private int nbPers = 0;
        private Client selectedClient;

        //private List<Client> client = ClientController.getClients();
        //private List<ClientFidele> clientFidele = ClientController.getClientsFideles();

        public FormResa(Voyage voyage)//constructeur attend un argument
        {
            InitializeComponent();

            //afficher la destination
            lblDestination.Text = voyage.Destination;

            v = voyage;

        }

        //ajouter un nombre de places à reserver
        private void btnNbPers_Click(object sender, EventArgs e)
        {
            try//implement this in the right place (done)
            {
                selectedClient = (Client)lbClients.SelectedItem;
            }
            catch (Exception)
            {

                MessageBox.Show("Sélectionnez un client");
            }
            

            //nombre de personnes pour le client selectionné
            try
            {
                nbPers = Convert.ToInt32(tbNbPers.Text);

                if (v.NbPlacesDispos < nbPers)
                {
                    btnConfirmer.Visible = false;
                    lblResultat.ForeColor = Color.Red;
                    lblResultat.Text = "Nombre de place insuffisant.\nPlaces disponibles: " + v.NbPlacesDispos;
                }
                else
                {
                    btnConfirmer.Visible = true;
                    lblResultat.ForeColor = Color.DarkGreen;
                    lblResultat.Text = "Le montant de la reservation: " + Resa.calculMontant(selectedClient, nbPers, v) + "€";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Veuillez saisir un nombre entier");
            }

            
            
        }

        /// <summary>
        /// creer la reservation et l'ajouter aux 2 listes (voyage et client)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            selectedClient = (Client)lbClients.SelectedItem;

            reservation1 = new Resa(v, selectedClient, nbPers);
            reservation1.confirmeResa();
            VoyageController.updateDispo(reservation1.LeVoyage);
            ResaController.addResa(reservation1.LeVoyage.Id, reservation1.Client.Id, reservation1.NbPersonne);
            //reservation1.LeVoyage.ajouterReservation(reservation1);
            //reservation1.Client.ajouterReservation(reservation1);

            //client devient client fidele au bout de 6 reservations
            /*if(reservation1.Client.ReservationsClient.Count() >= 6)
            {
                Client nvoCliF = new ClientFidele(selectedClient.Id, selectedClient.Nom, selectedClient.Prenom, selectedClient.Tel, selectedClient.Adresse, selectedClient.Mail, 5);
                nvoCliF.Id = selectedClient.Id;
                nvoCliF.ReservationsClient = selectedClient.ReservationsClient;
                //clients.Add(nvoCliF);
                //clients.Remove(selectedClient);
            }*/


            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// inscrire un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInscrire_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                int tel = int.Parse(txtTel.Text);
                string adresse = txtAdresse.Text;
                string mail = txtMail.Text;

                if(nom.Length == 0 || prenom.Length == 0 || adresse.Length == 0 || mail.Length == 0)
                {
                    throw new Exception();
                }

                ClientController.addClient(nom, prenom, tel, adresse, mail);

            }
            catch (Exception)
            {

                MessageBox.Show("Veuillez remplir tous les champs.");
            }
      
        }

        /// <summary>
        /// selon le type de client selectionné affiche la liste correspondante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTypeCli_Click(object sender, EventArgs e)
        {
            List<Client> clients = ClientController.getAll();
            List<Client> client = ClientController.getClients();
            List<ClientFidele> clientFidele = ClientController.getClientsFideles();

            if (cbClient.Checked && cbCFidele.Checked)
            {
                //lbClients.DataSource = null;
                lbClients.DataSource = clients;
                lbClients.DisplayMember = "Disp";
            }
            else if (cbClient.Checked)
            {
                //lbClients.DataSource = null;
                lbClients.DataSource = client;
                lbClients.DisplayMember = "Disp";
            }
            else if (cbCFidele.Checked)
            {
                //lbClients.DataSource = null;
                lbClients.DataSource = clientFidele;
                lbClients.DisplayMember = "Disp";
            }

            cbClient.Checked = false;
            cbCFidele.Checked = false;
        }

        /// <summary>
        /// ouvrir le formClient en lui envoyant le client selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbClients_DoubleClick(object sender, EventArgs e)
        {
            Client selectedCli = (Client)lbClients.SelectedItem;

            FormClient form3 = new FormClient(selectedCli);
            form3.ShowDialog();

            //btnTypeCli.Click += new EventHandler(btnTypeCli_Click);

        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
