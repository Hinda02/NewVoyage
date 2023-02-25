using MySql.Data.MySqlClient;
using NewVoyage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.Controller
{
    public class VoyageController
    {
        //private static List<Voyage> voyageList = new List<Voyage>();
        public static List<Voyage> getVoyages()
        {
            MySqlDataReader reader = ManipVoyage.getVoyages();

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

            return voyageList;
        }
    }
}
