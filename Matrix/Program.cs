
using System.Resources;
using Matrix;
const int SIZE = 15;
MatrixP matrix = MatrixFactory.CreateMatrix(SIZE);


init(matrix);
static void init(MatrixP matrix)
{
    const int TURNOS = 20;
    int num_muertes;

    for (int i = 1; i <= TURNOS; i++)
    {

        num_muertes = matrix.turnoGenerico();

        if (i % 2 == 0)
        {
            matrix.turnoSmith();
        }

        if (i % 5 == 0)
        {
            matrix.turnoNeo();
        }
        Console.WriteLine("TURNO: " + i + "/" + TURNOS);
        Console.WriteLine(" ");
        Utilidades.mostrarLaMatrix(matrix);
        Console.WriteLine(" ");
        Console.WriteLine("Ha habido " + num_muertes + " muertes naturales.");
        Console.WriteLine(" ");
        Thread.Sleep(1000);
    }
}
