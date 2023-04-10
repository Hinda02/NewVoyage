using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NewVoyage.DAL;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using NewVoyage.Controller;
using MySqlX.XDevAPI;

namespace NewVoyage
{
    public partial class FormVoyage : Form
    {

        private List<Voyage> listVoyage; 
        
        public FormVoyage()//c'est le constructeur de la classe
        {
            InitializeComponent();


            listVoyage = VoyageController.getAll();
            
            lDestination.DataSource = listVoyage;
            lDestination.DisplayMember = "Destination";
          

        }

        /// <summary>
        /// affiche les infos de la destination selectionnee
        /// premier test de possibilite de reservation selon nbPlacesDispos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = lDestination.SelectedIndex;
            Voyage v = listVoyage[i];

            //affichage des infos du voyage
            lblDateD.Text = v.DateDepart.ToShortDateString();
            lblDateR.Text = v.DateRetour.ToShortDateString();
            lblPrix.Text = v.Prix.ToString();
            lblTaxe.Text = v.Taxe.ToString();
            lblPlDispo.Text = v.NbPlacesDispos.ToString();

            //lReservations.Items.Clear();
            lReservations.DataSource = ResaController.getByIdV(v);
            lReservations.DisplayMember = "Display";

            //afficher les reservations liees a cette destination
            /*for (int k = 0; k <= v.LReservations.Count - 1; k++)
            {
                lReservations.Items.Add(v.LReservations[k].afficher());
            }*/

            //gerer l'affichage du bouton reserver
            if (v.NbPlacesDispos > 0)
            {
                btnResa.Enabled = true;
                lblWarning.Text = "";
            }
            else
            {
                btnResa.Enabled = false;
                lblWarning.Text = "Reservation impossible: aucune place n'est disponible";
            }

        }

        /// <summary>
        /// ouvrir formResa et mettre a jour les infos de la destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResa_Click(object sender, EventArgs e)
        {
            int index = lDestination.SelectedIndex;
            Voyage v = listVoyage[index];
   
            FormResa form2 = new FormResa(v);
            form2.ShowDialog();

            lDestination.SetSelected(index, true);


        }

        private void FormVoyage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Serialisation.sauvegarder(listVoyage);
        }

    }
}
