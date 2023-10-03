using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class MatrixFactory
    {
        public static MatrixP CreateMatrix(int tamano)
        {
            Random rand = new Random();
            int latitud;
            int longitud;
            MatrixP matrix;

            Personaje[,] matriz = new Personaje[tamano, tamano];

            Generico[] genericos = GenericFactory.CreateAGeneric(matriz.Length / 3);

            Neo neo = NeoFactory.CreateNeo();

            Smith smith = SmithFactory.CreateSmith();

            latitud = rand.Next(tamano);
            longitud = rand.Next(tamano);

            smith.Latitud = latitud;
            smith.Longitud = longitud;

            matriz[latitud, longitud] = smith;

            do
            {
                latitud = rand.Next(tamano);
                longitud = rand.Next(tamano);
            } while (matriz[latitud, longitud] != null);

            neo.Latitud = latitud;
            neo.Longitud = longitud;

            matriz[latitud, longitud] = neo;

            for (int i = 0;i < genericos.Length; i++)
            {
                do
                {
                    latitud = rand.Next(tamano);
                    longitud = rand.Next(tamano);
                } while (matriz[latitud, longitud] != null);

                genericos[i].Latitud = latitud;
                genericos[i].Longitud = longitud;

                matriz[latitud, longitud] = genericos[i];
            }

            matrix = new MatrixP(matriz);

            return matrix;
        }
    }
}
