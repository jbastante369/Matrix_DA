using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Smith : Personaje
    {
        private int prob_infectar;

        public Smith(String nombre, int edad, int latitud, int longitud, String ciudad, int prob_infectar) :
            base(nombre, edad, latitud, longitud, ciudad)
        {
            this.prob_infectar = prob_infectar;
        }

        public int Prob_infectar
        {
            get
            {
                return prob_infectar;
            }
            set
            {
                this.prob_infectar = value;
            }
        }

        public static void moverSmith(Personaje[,] matrix)
        {
            Random rand = new Random();
            int latitud_Smith = 0;
            int longitud_Smith = 0;
            int latitud_Neo = 0;
            int longitud_Neo = 0;
            int y, x;
            Utilidades.localizacionDeNeo(matrix, ref latitud_Neo, ref longitud_Neo);
            Neo neo = (Neo)matrix[latitud_Neo, longitud_Neo];
            Utilidades.localizacionDeSmith(matrix, ref latitud_Smith, ref longitud_Smith);
            Smith smith = (Smith)matrix[latitud_Smith, longitud_Smith];


            if (!Utilidades.smithCercaDeNeo(matrix))
            {
                
                do
                {
                    matrix[smith.Latitud, smith.Longitud] = null;
                    if (smith.Latitud > neo.Latitud && smith.Longitud < neo.Longitud)
                    {
                        smith.Latitud--;
                        smith.Longitud++;
                    }
                    else if (smith.Latitud < neo.Latitud && smith.Longitud > neo.Longitud)
                    {
                        smith.Latitud++;
                        smith.Longitud--;
                    }
                    else if (smith.Latitud < neo.Latitud && smith.Longitud < neo.Longitud)
                    {
                        smith.Latitud++;
                        smith.Longitud++;
                    }
                    else if (smith.Latitud > neo.Latitud && smith.Longitud > neo.Longitud)
                    {
                        smith.Latitud--;
                        smith.Longitud--;
                    } 
                    else if (smith.Latitud > neo.Latitud && smith.Longitud < neo.Longitud)
                    {
                        smith.Latitud++;
                        smith.Longitud++;
                    }
                    else if (smith.Latitud <= neo.Latitud && smith.Longitud > neo.Longitud)
                    {
                        smith.Latitud++;
                        smith.Longitud--;
                    }
                    else if (smith.Latitud < neo.Latitud && smith.Longitud <= neo.Longitud)
                    {
                        smith.Latitud++;
                        smith.Longitud--;
                    }
                    else if (smith.Latitud > neo.Latitud && smith.Longitud >= neo.Longitud)
                    {
                        smith.Latitud--;
                        smith.Longitud++;
                    }

                    matrix[smith.Latitud, smith.Longitud] = smith;
                } while (!Utilidades.smithCercaDeNeo(matrix));
                
            }


            Console.WriteLine(Math.Max(Math.Abs(latitud_Neo-latitud_Smith),Math.Abs(longitud_Neo-longitud_Smith)));
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Elegido: " + this.Prob_infectar;
        }
    }
}
