using System;
using System.Collections.Generic;
using System.Linq;
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

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Elegido: " + this.elegido;
        }
    }
}
