using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Utilidades
    {
        public static void mostrarLaMatrix(MatrixP matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix.matrix[i, j] is Generico)
                    {
                        Console.Write("[ O ]");
                    }
                    if (matrix.matrix[i, j] is Neo)
                    {
                        Console.Write("[ N ]");
                    }
                    if (matrix.matrix[i, j] is Smith)
                    {
                        Console.Write("[ S ]");
                    }
                    if (matrix.matrix[i, j] is null)
                    {
                        Console.Write("[   ]");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void localizacionDeNeo(Personaje[,] matrix, ref int latitud,ref int longitud)
        {
            bool encontrado = false;
            for(int i = 0;i < matrix.GetLength(0) && !encontrado;i++) 
            {
                for (int j = 0; j < matrix.GetLength(1) && !encontrado; j++)
                {
                    if (matrix[i,j] is Neo)
                    {
                        latitud = i;
                        longitud = j;
                        encontrado = true;
                    }
                }
            }
        }

        public static void localizacionDeSmith(Personaje[,] matrix, ref int latitud, ref int longitud)
        {
            bool encontrado = false;
            for (int i = 0; i < matrix.GetLength(0) && !encontrado; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) && !encontrado; j++)
                {
                    if (matrix[i, j] is Smith)
                    {
                        latitud = i;
                        longitud = j;
                        encontrado = true;
                    }
                }
            }
        }

        public static bool smithCercaDeNeo(Personaje[,] matrix)
        {
            bool cerca = false;
            int latitud = 0;
            int longitud = 0;
            Utilidades.localizacionDeNeo(matrix, ref latitud, ref longitud);
            Neo neo = (Neo)matrix[latitud, longitud];
            for (int i = latitud - 1; i <= latitud + 1 && !cerca; i++)
            {

                for (int j = longitud - 1; j <= longitud + 1 && !cerca; j++)
                {
                    if (!(i < 0 || i > matrix.GetLength(0) - 1 || j < 0 || j > matrix.GetLength(1) - 1))
                    {
                        if (matrix[i, j] is Smith)
                        {
                            cerca = true;
                        }

                    }
                }
            }
            return cerca;
        }

    }


}
