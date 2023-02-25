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

        public static MySqlDataReader getVoyages()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from voyage;");

            MySqlDataReader reader = connect.queryExec(request);

            return reader;
        }


    }
}
