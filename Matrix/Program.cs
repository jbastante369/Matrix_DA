
using System.Resources;
using Matrix;

MatrixP matrix = MatrixFactory.CreateMatrix(15);


init(ref matrix);
static void init(ref MatrixP matrix)
{
    Utilidades.mostrarLaMatrix(matrix);
    matrix.turnoNeo();
}
