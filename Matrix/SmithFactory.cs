using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class SmithFactory
    {
        public static Smith CreateSmith()
        {
            String[] ciudad = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };
            Random rand = new Random();
            const int EDAD = 37;
            const String NOMBRE = "Smith";



            return new Smith(NOMBRE, EDAD, 0, 0, ciudad[rand.Next(ciudad.Length)], 100);
        }
    }
}
