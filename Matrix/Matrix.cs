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

        public int turnoGenerico()
        {
            return Generico.matarGenericos(this.matrix);
        }

        public void turnoNeo()
        {
            Neo.renacerPersonaje(this.matrix);
            Neo.moverNeo(this.matrix);
        }

        public void turnoSmith()
        {
            Smith.moverSmith(this.matrix);
        }
    }
}
