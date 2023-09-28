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

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Elegido: " + this.Prob_infectar;
        }
    }
}
