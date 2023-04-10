using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.DAL
{
    public class ManipVoyage
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "voyagestesting", "root", "");

        public static List<Voyage> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from voyage;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Voyage> voyageList = new List<Voyage>();

            while (reader.Read())
            {
                int id = (int)reader["idVoyage"];
                string destination = (string)reader["destination"];
                double prix = (double)reader["prix"];
                double taxe = (double)reader["taxe"];
                DateTime dateDep = (DateTime)reader["dateDepart"];
                DateTime dateRet = (DateTime)reader["dateRetour"];
                int nbPlaces = (int)reader["nbPlacesDispo"];

                Voyage voyage = new Voyage(id, destination, prix, taxe, dateDep, dateRet, nbPlaces);

                voyageList.Add(voyage);
            }

            reader.Close();
            connect.closeConnection();

            return voyageList;
        }

        public static Voyage getById(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from voyage where idVoyage = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            Voyage voyage = null;

            while (reader.Read())
            {
                int idV = (int)reader["idVoyage"];
                string destination = (string)reader["destination"];
                double prix = (double)reader["prix"];
                double taxe = (double)reader["taxe"];
                DateTime dateDep = (DateTime)reader["dateDepart"];
                DateTime dateRet = (DateTime)reader["dateRetour"];
                int nbPlaces = (int)reader["nbPlacesDispo"];

                voyage = new Voyage(idV, destination, prix, taxe, dateDep, dateRet, nbPlaces);

            }

            reader.Close();
            connect.closeConnection();

            return voyage;
        }

        public static void updateDispo(Voyage v)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("UPDATE voyage SET nbPlacesDispo = '" + v.NbPlacesDispos + "' WHERE idVoyage = '" + v.Id + "';");

            connect.nonQueryExec(request);

            connect.closeConnection();
        }


    }
}
