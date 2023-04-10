using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.DAL
{
    public class ManipClient
    {

        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "voyagestesting", "root", "");

        public static List<Client> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from client;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Client> clientList = new List<Client>();

            while (reader.Read())
            {
                int id = (int)reader["idClient"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                double tauxReduction = (double)reader["tauxReduction"];

                Client cli = new Client(id, nom, prenom, tel, adresse, mail, tauxReduction);

                clientList.Add(cli);
            }

            reader.Close();
            connect.closeConnection();


            return clientList;
        }

        public static Client getById(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from client where idClient = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            Client client = null;

            while (reader.Read())
            {
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];


                client = new Client(nom, prenom, tel, adresse, mail);

            }

            reader.Close();
            connect.closeConnection();

            return client;
        }

        public static List<Client> getClients()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from client where tauxReduction = 0;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Client> clientList = new List<Client>();

            while (reader.Read())
            {
                int id = (int)reader["idClient"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                double tauxReduction = (double)reader["tauxReduction"];

                Client cli = new Client(id, nom, prenom, tel, adresse, mail, tauxReduction);

                clientList.Add(cli);
            }

            reader.Close();
            connect.closeConnection();

            return clientList;
        }

        public static List<ClientFidele> getClientsFideles()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from client where tauxReduction <> 0;");

            MySqlDataReader reader = connect.queryExec(request);

            List<ClientFidele> clientList = new List<ClientFidele>();

            while (reader.Read())
            {
                int id = (int)reader["idClient"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                double tauxReduction = (double)reader["tauxReduction"];

                ClientFidele cli = new ClientFidele(id, nom, prenom, tel, adresse, mail, tauxReduction);

                clientList.Add(cli);
            }

            reader.Close();
            connect.closeConnection();

            return clientList;
        }

        public static void addClient(string nom, string prenom, int tel, string adresse, string mail)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("INSERT INTO client (nom, prenom, tel, adresse, mail) VALUES " +
                "('" + nom + "', '" + prenom + "', '" + tel + "', '" + adresse + "', '" + mail + "');");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }

        public static void updateClient(Client c, string nom, string prenom, int tel, string adresse, string mail)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("UPDATE client SET nom = '" + nom + "', prenom = '" 
                + prenom + "', tel = '" + tel + "', adresse = '" + adresse + "', mail = '" + mail + "' WHERE idClient = '" + c.Id + "';");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }

    }
}
