
using System.Resources;
using Matrix;

MatrixP matrix = MatrixFactory.CreateMatrix(2);


init(matrix);
static void init(MatrixP matrix)
{
    Utilidades.mostrarLaMatrix(matrix);
    matrix.turnoNeo();
    Console.WriteLine(" ");
    Utilidades.mostrarLaMatrix(matrix);
}
