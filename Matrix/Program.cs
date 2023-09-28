
using System.Resources;
using Matrix;

MatrixP matrix = MatrixFactory.CreateMatrix(5);


init(matrix);
static void init(MatrixP matrix)
{
    Utilidades.mostrarLaMatrix(matrix);
    Console.WriteLine(" ");
    matrix.turnoNeo();
    Utilidades.mostrarLaMatrix(matrix);
}
