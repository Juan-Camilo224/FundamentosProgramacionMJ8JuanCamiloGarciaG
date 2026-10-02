using System;

namespace _16.arreglosBidimensionaL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[,] matriz = new int[10, 20];


            for (int fila = 0; fila < 10; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    Console.WriteLine("Fila " + fila + ", columna " + columna);
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            for (int columna = 0; columna < 20; columna++)
            {
                int suma = 0;
                for (int fila = 0; fila < 10; fila++)
                {
                    suma += matriz[fila, columna];
                }
                Console.WriteLine("Suma de la columna " + columna + ": " + suma);
            }

            */
            int n = 2;
            int m = 2; 
            char[,] matriz = new char[n, m];

            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    Console.WriteLine("Fila " + fila + ", columna " + columna);
                    matriz[fila, columna] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++) Console.Write(matriz[fila, columna] + " ");
                Console.WriteLine();
            }

            for (int columna = 0; columna < m; columna++)
            {
                char temp = matriz[0, columna];
                matriz[0, columna] = matriz[n - 1, columna];
                matriz[n - 1, columna] = temp;
            }

            Console.WriteLine("Matriz con filas intercambiadas:");
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++) Console.Write(matriz[fila, columna] + " ");
                Console.WriteLine();
            }

        }
    }
}
  