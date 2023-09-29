using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    internal class MatrixP
    {
        public Personaje[,] matrix {get ;set ;}

        public MatrixP(Personaje[,] matrix)
        {
            this.matrix = matrix;
        }

        public void turnoGenerico()
        {
            Generico generico;

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for(int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i,j] is Generico)
                    {
                        generico = (Generico)this.matrix[i,j];
                        
                        if (generico.Prob_morir > 70)
                        {
                            generico = GenericFactory.CreateGeneric();
                            generico.Latitud = i;
                            generico.Longitud = j;
                            this.matrix[i,j] = generico;
                        }
                        else
                        {
                            generico.Prob_morir += 10;
                            this.matrix[i, j] = generico;
                        }
                    }
                }
            }
        }

        public void turnoNeo()
        {
            Neo.renacerPersonaje(this.matrix);
            Utilidades.mostrarLaMatrix(this);
            Console.WriteLine(" ");
            Neo.moverNeo(this.matrix);
        }

        public void turnoSmith()
        {
            Smith.moverSmith(this.matrix);
        }
    }
}
