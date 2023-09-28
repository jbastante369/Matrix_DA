using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class NeoFactory
    {
        public static Neo CreateNeo()
        {
            String[] ciudad = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
            Random rand = new Random();
            const int EDAD = 37;
            const String NOMBRE = "Neo";



            return new Neo(NOMBRE, EDAD, 0, 0, ciudad[rand.Next(ciudad.Length)], false);
        }
    }
}
