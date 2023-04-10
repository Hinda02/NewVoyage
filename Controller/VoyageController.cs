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
        public static List<Voyage> getAll()
        {
            List<Voyage> listVoyage = ManipVoyage.getAll();

            return listVoyage;
        }

        public static Voyage getById(int id)
        { 
            Voyage voyage = ManipVoyage.getById(id);
            return voyage;
        }

            public static void updateDispo(Voyage v)
        {
            ManipVoyage.updateDispo(v);
        }
    }
}
