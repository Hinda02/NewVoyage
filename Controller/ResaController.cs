using NewVoyage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVoyage.Controller
{
    public class ResaController
    {
        public static void addResa(int voyage, int client, int nbPers)
        {
            ManipResa.addResa(voyage, client, nbPers);
        }

        public static List<Resa> getByIdC(Client c)
        {
            List<Resa> resaList = ManipResa.getByIdC(c);
            return resaList;
        }

        public static List<Resa> getByIdV(Voyage v)
        {
            List<Resa> resaList = ManipResa.getByIdV(v);
            return resaList;
        }
    }
}
