using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Generico : Personaje
    {
        private int prob_morir;

        public Generico(String nombre, int edad, int latitud,int longitud,String ciudad, int prob_morir) : 
            base(nombre,edad, latitud, longitud, ciudad)
        {
            this.prob_morir = prob_morir;   
        }

        public int Prob_morir
        {
            get
            {
                return prob_morir;
            }
            set
            {
                this.prob_morir = value;
            }
        }

        public static int matarGenericos(Personaje[,] matrix)
        {
            int num_muertes = 0;

            Generico generico;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] is Generico)
                    {
                        generico = (Generico)matrix[i, j];

                        if (generico.Prob_morir > 70)
                        {
                            num_muertes++;
                            generico = GenericFactory.CreateGeneric();
                            generico.Latitud = i;
                            generico.Longitud = j;
                            matrix[i, j] = generico;
                        }
                        else
                        {
                            generico.Prob_morir += 10;
                            matrix[i, j] = generico;
                        }
                    }
                }
            }

            return num_muertes;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Probabilidad muerte: " + this.prob_morir + "%";
        }
    }
}
