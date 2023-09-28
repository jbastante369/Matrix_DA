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

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Probabilidad muerte: " + this.prob_morir + "%";
        }
    }
}
