using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage
{
    public class Serialisation
    {

        public static void sauvegarder(object data)
        {
            FileStream stream = new FileStream("data", FileMode.Create);

            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(stream, data);

            stream.Close();
        }

        public static void sauvegarderClients(object data)
        {
            FileStream stream = new FileStream("clients", FileMode.Create);

            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(stream, data);

            stream.Close();
        }

        public static void sauvegarderID(object data)
        {
            FileStream stream = new FileStream("ids", FileMode.Create);

            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(stream, data);

            stream.Close();
        }

        public static List<Voyage> chargement()
        {
            if (File.Exists("data"))
            {

                BinaryFormatter deserializer = new BinaryFormatter();

                FileStream stream = new FileStream("data", FileMode.Open);

                List<Voyage> listVoyage;

                listVoyage = (List<Voyage>)deserializer.Deserialize(stream);

                stream.Close();

                return listVoyage;

            }
            else
            {
                return new List<Voyage>();
            }
        }


        public static List<Client> chargerClients()
        {
            if (File.Exists("clients"))
            {

                BinaryFormatter deserializer = new BinaryFormatter();

                FileStream stream = new FileStream("clients", FileMode.Open);

                List<Client> listClient;

                listClient = (List<Client>)deserializer.Deserialize(stream);

                stream.Close();

                return listClient;

            }
            else
            {
                return new List<Client>();
            }
        }

        public static int chargerID()
        {
            if (File.Exists("ids"))
            {

                BinaryFormatter deserializer = new BinaryFormatter();

                FileStream stream = new FileStream("ids", FileMode.Open);

                int id;

                id = (int)deserializer.Deserialize(stream);

                stream.Close();

                return id;

            }
            else
            {
                return 0;
            }
        }
    }
}
