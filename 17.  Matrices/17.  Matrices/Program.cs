using System;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese número de filas");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número de columnas");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];


            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    Console.WriteLine("Fila " + fila + ", columna " + columna);
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("Ingrese el valor umbral N");
            int N = int.Parse(Console.ReadLine());

            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    if (matriz[fila, columna] < N)
                    {
                        matriz[fila, columna] = N;
                    }
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
