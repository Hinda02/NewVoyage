using MySql.Data.MySqlClient;
using NewVoyage.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.DAL
{
    public class ManipResa
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "voyagestesting", "root", "");

        public static List<Resa> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from resa;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Resa> resaList = new List<Resa>();

            while (reader.Read())
            {
                int id = (int)reader["idResa"];
                int idV = (int)reader["idVoyage"];
                int idC = (int)reader["idClient"];
                int nbP = (int)reader["nbPersonne"];

                Voyage voyage = VoyageController.getById(idV);
                Client client = ClientController.getById(idC);

                Resa resa = new Resa(voyage, client, nbP);

                resaList.Add(resa);
            }

            reader.Close();
            connect.openConnection();


            return resaList;
        }

        public static List<Resa> getByIdV(Voyage v)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from voyage inner join resa " +
                    "on voyage.idVoyage = resa.idVoyage" +
                    " inner join client on resa.idClient = client.idClient" +
                    " where voyage.idVoyage = " + v.Id + " ;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Resa> resaList = new List<Resa>();

            while (reader.Read())
            {
                int id = (int)reader["idResa"];
                int nbP = (int)reader["nbPersonne"];

                //Voyage
                int idV = (int)reader["idVoyage"];
                string destination = (string)reader["destination"];
                double prix = (double)reader["prix"];
                double taxe = (double)reader["taxe"];
                DateTime dateDep = (DateTime)reader["dateDepart"];
                DateTime dateRet = (DateTime)reader["dateRetour"];
                int nbPlaces = (int)reader["nbPlacesDispo"];

                Voyage voyage = new Voyage(idV, destination, prix, taxe, dateDep, dateRet, nbPlaces);

                //Client
                int idC = (int)reader["idClient"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                double tauxReduction = (double)reader["tauxReduction"];

                Client cli = new Client(idC, nom, prenom, tel, adresse, mail, tauxReduction);

                Resa resa = new Resa(voyage, cli, nbP);

                resaList.Add(resa);
            }

            reader.Close();


            connect.closeConnection();

            return resaList;
        }

        public static List<Resa> getByIdC(Client c)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from voyage inner join resa " +
                    "on voyage.idVoyage = resa.idVoyage" +
                    " inner join client on resa.idClient = client.idClient" +
                    " where client.idClient = " + c.Id + " ;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Resa> resaList = new List<Resa>();

            while (reader.Read())
            {
                int id = (int)reader["idResa"];
                int nbP = (int)reader["nbPersonne"];

                //Voyage
                int idV = (int)reader["idVoyage"];
                string destination = (string)reader["destination"];
                double prix = (double)reader["prix"];
                double taxe = (double)reader["taxe"];
                DateTime dateDep = (DateTime)reader["dateDepart"];
                DateTime dateRet = (DateTime)reader["dateRetour"];
                int nbPlaces = (int)reader["nbPlacesDispo"];

                Voyage voyage = new Voyage(idV, destination, prix, taxe, dateDep, dateRet, nbPlaces);

                //Client
                int idC = (int)reader["idClient"];
                string nom = (string)reader["nom"];
                string prenom = (string)reader["prenom"];
                int tel = (int)reader["tel"];
                string adresse = (string)reader["adresse"];
                string mail = (string)reader["mail"];
                double tauxReduction = (double)reader["tauxReduction"];

                Client cli = new Client(idC, nom, prenom, tel, adresse, mail, tauxReduction);

                Resa resa = new Resa(voyage, cli, nbP);

                resaList.Add(resa);
            }

            reader.Close();


            connect.closeConnection();

            return resaList;
        }

        public static void addResa(int voyage, int client, int nbPers)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("INSERT INTO resa (idVoyage, idClient, nbPersonne) VALUES " +
                "('" + voyage + "', '" + client + "', '" + nbPers + "');");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }
    }
}
