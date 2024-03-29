﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.DAL
{
    public class ConnexionSql
    {

        // Variable locale pour stocker une référence vers l'instance
        private static ConnexionSql connection = null;

        private MySqlConnection mySqlCn;

        private static readonly object mylock = new object();



        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                string connString;

                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";

                try
                {
                    mySqlCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);

            }



        }



        /**
         * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { // Premier appel
                        connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                    }
                }
                catch (Exception emp)
                {


                    throw (emp);

                }
                return connection;

            }
        }





        /**
         * Ouverture de la connexion
         */
        public void openConnection()
        {
            if (mySqlCn.State == System.Data.ConnectionState.Closed)
                mySqlCn.Open();

        }

        /**
         * Fermeture de la connexion
         */
        public void closeConnection()
        {
            if (mySqlCn.State == System.Data.ConnectionState.Open)
                mySqlCn.Close();
        }

        /**
         * Exécution d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mySqlCn);
            mysqlCom.CommandType = CommandType.Text;
            return (mysqlCom);
        }

        public MySqlDataReader queryExec(MySqlCommand cmd)
        {
            return cmd.ExecuteReader();
        }

        public void nonQueryExec(MySqlCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public MySqlCommand ModifiyCommand(string id, string nom, string prenom, string nationalite)
        {
            MySqlCommand mysqlCom = new MySqlCommand("UPDATE auteur SET nom = '" + nom + "', prenom = '" + prenom + "', nationalite = '" + nationalite + "' WHERE num = '" + id + "';", this.mySqlCn);
            return (mysqlCom);
        }

        public MySqlCommand DeleteCommand(string id)
        {
            MySqlCommand mysqlCom = new MySqlCommand("DELETE FROM auteur WHERE num = '" + id + "';", this.mySqlCn);
            return (mysqlCom);
        }

        public MySqlCommand InsertCommand(string nom, string prenom, string nationalite)
        {
            MySqlCommand mysqlCom = new MySqlCommand("INSERT INTO auteur (nom, prenom, nationalite) VALUES ('" + nom + "', '" + prenom + "', '" + nationalite + "');", this.mySqlCn);
            return (mysqlCom);
        }

    }
}
