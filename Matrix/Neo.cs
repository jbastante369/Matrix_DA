﻿using System;
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

        public static void moverNeo(Personaje[,] matrix )
        {
            Random rand = new Random();
            int latitud = 0;
            int longitud = 0;
            int y, x;
            Utilidades.localizacionDeNeo(matrix, ref latitud, ref longitud);
            Neo neo = (Neo)matrix[latitud,longitud];
            
            y = rand.Next(matrix.GetLength(0));
            x = rand.Next(matrix.GetLength(0));
            neo.Latitud = y;
            neo.Longitud = x;

            if (matrix[y,x] is null)
            {
                matrix[y,x] = neo;
                matrix[latitud, longitud] = null;
            }
            else
            {
                matrix[x,y].Latitud = latitud;
                matrix[x,y].Longitud = longitud;
                matrix[latitud,longitud] = matrix[y,x];
                matrix[y,x] = neo;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Elegido: " + this.elegido;
        }
    }
}
