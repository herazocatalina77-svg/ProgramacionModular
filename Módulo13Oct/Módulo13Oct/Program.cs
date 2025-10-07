using System;
namespace Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosde5 = new int[CapturarFilas(), CapturarColumnas()];
        }
        static int[,] LlenarMatriz(int[,] matriz)
        {
            return matriz;
        }
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz:");
            int filas=Convert.ToInt32(Console.ReadLine());
            return filas;
        }
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de Columnas para la matriz:");
            int filas = Convert.ToInt32(Console.ReadLine());
            return filas;
        }
    }
}