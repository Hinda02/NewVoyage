using MySql.Data.MySqlClient;
using NewVoyage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.Controller
{
    public class ClientController
    {
        public static List<Client> getAll()
        {
            List<Client> listClient = ManipClient.getAll();

            return listClient;
        }

        public static Client getById(int id)
        { 
            Client client = ManipClient.getById(id);
            return client;
        }

            public static List<Client> getClients()
        {
            List<Client> listClient = ManipClient.getClients();

            return listClient;
        }

        public static List<ClientFidele> getClientsFideles()
        {
            List<ClientFidele> listClient = ManipClient.getClientsFideles();

            return listClient;
        }

        public static void addClient(string nom, string prenom, int tel, string adresse, string mail)
        {
            ManipClient.addClient(nom, prenom, tel, adresse, mail);

        }

        public static void updateClient(Client c, string nom, string prenom, int tel, string adresse, string mail)
        {
            ManipClient.updateClient(c, nom, prenom, tel, adresse, mail);

        }
    }
}
