using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Personaje
    {
        protected String nombre;
        protected int edad;
        protected int latitud;
        protected int longitud;
        protected String ciudad;
        static int personajes_creados = 0;

        public Personaje(String nombre, int edad,int latitud,int longitud,String ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.latitud = latitud;
            this.longitud = longitud;
            this.ciudad = ciudad;
            personajes_creados++;
        }

        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public int Latitud
        {
            get
            {
                return latitud;
            }
            set
            {
                this.latitud = value;
            }
        }

        public int Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                this.longitud = value;
            }
        }

        public String Ciudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                this.ciudad = value;
            }
        }

        public override string ToString()
        {
            return  "Personaje: \n" +
                    "Nombre: " + this.nombre + "\n" +
                    "Edad: " + this.edad + "\n" +
                    "Latitud: " + this.latitud + "\n" +
                    "Longitud: " + this.longitud + "\n" +
                    "Ciudad: " + this.ciudad;
        }
    }
}
