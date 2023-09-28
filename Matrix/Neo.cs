using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Neo : Personaje
    {
        private bool elegido;

        public Neo(String nombre, int edad, int latitud, int longitud, String ciudad, bool elegido) :
            base(nombre, edad, latitud, longitud, ciudad)
        {
            this.elegido = elegido;
        }

        public bool Elegido
        {
            get
            {
                return elegido;
            }
            set
            {
                this.elegido = value;
            }
        }

        public void esElElegido()
        {
            Random rnd = new Random();
            if (rnd.Next(101) >50) 
            {
                this.elegido = true;
            }
            else
            {
                this.elegido = false;
            }
        }

        public static void moverNeo(Personaje[,] matrix )
        {
            Random rand = new Random();
            int latitud = 0;
            int longitud = 0;
            int y, x;
            Utilidades.localizacionDeNeo(matrix, ref latitud, ref longitud);
            Neo neo = (Neo)matrix[latitud,longitud];
            
            y = rand.Next(matrix.GetLength(0));
            x = rand.Next(matrix.GetLength(1));
            neo.Latitud = y;
            neo.Longitud = x;

            if (matrix[y,x] is null)
            {
                matrix[y,x] = neo;
                matrix[latitud, longitud] = null;
            }
            else
            {
                matrix[y,x].Latitud = latitud;
                matrix[y,x].Longitud = longitud;
                matrix[latitud,longitud] = matrix[y,x];
                matrix[y,x] = neo;
            }
        }

        public static void renacerPersonaje(Personaje[,] matrix)
        {
            bool renace = false;
            Generico generico;
            int latitud = 0;
            int longitud = 0;
            Utilidades.localizacionDeNeo(matrix, ref latitud, ref longitud);
            Neo neo = (Neo)matrix[latitud, longitud];
            neo.esElElegido();
            if (neo.Elegido)
            {
                for (int i = latitud - 1; i <= latitud + 1 && !renace; i++)
                {
                    
                    for (int j = longitud - 1; j <= longitud + 1 && !renace; j++)
                    {
                        Console.WriteLine(i +","+ j);
                        if (!(i < 0 || i > matrix.GetLength(0) - 1 || j < 0 || j > matrix.GetLength(1) - 1))
                        {
                            if (matrix[i,j] is null)
                            {
                                generico = GenericFactory.CreateGeneric();
                                generico.Latitud = i;
                                generico.Longitud = j;
                                matrix[i, j] = generico;
                                renace = true;
                            }
                            
                        }
                    }
                }
            }
            
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Elegido: " + this.elegido;
        }
    }
}
