using NewVoyage.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewVoyage
{
    public partial class FormClient : Form
    {
        Client cli;

        public FormClient(Client client)
        {
            InitializeComponent();

            cli = client;

            //afficher les infos du client selectionné
            lblId.Text = "Client " + client.Id.ToString();
            tbNom.Text = client.Nom;
            tbPrenom.Text = client.Prenom;
            tbTel.Text = client.Tel.ToString();
            tbAdresse.Text = client.Adresse;
            tbMail.Text = client.Mail;

            lResa.DataSource = ResaController.getByIdC(client);
            lResa.DisplayMember = "Display";

            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// modifier les infos du client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            /*cli.Nom = tbNom.Text;
            cli.Prenom = tbPrenom.Text;
            cli.Tel = int.Parse(tbTel.Text);
            cli.Adresse = tbAdresse.Text;
            cli.Mail = tbMail.Text;*/

            ClientController.updateClient(cli, tbNom.Text, tbPrenom.Text, int.Parse(tbTel.Text), tbAdresse.Text, tbMail.Text);

        }
    }
}
