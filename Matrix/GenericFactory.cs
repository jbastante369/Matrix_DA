using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class GenericFactory
    {
        public static Generico CreateGeneric() {
            String[] nombre = { "Michelle", "Alexander", "James", "Caroline", "Claire", "Jessica", "Erik", "Mike" };
            String[] ciudad = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
            const int EDAD_MIN = 18;
            const int EDAD_MAX = 71;
            const int MAX_PROP = 101;

            Random rand = new Random();
            return new Generico(nombre[rand.Next(nombre.Length)],
                                      rand.Next(EDAD_MIN, EDAD_MAX),
                                      0,
                                      0,
                                      ciudad[rand.Next(ciudad.Length)],
                                      rand.Next(MAX_PROP));

        }

        public static Generico[] CreateAGeneric(int tamano)
        {
            Generico[] arrayg = new Generico[tamano];

            for (int i = 0; i < arrayg.Length; i++)
            {
                arrayg[i] = CreateGeneric();
            }
            return arrayg;

        }

    }
}
