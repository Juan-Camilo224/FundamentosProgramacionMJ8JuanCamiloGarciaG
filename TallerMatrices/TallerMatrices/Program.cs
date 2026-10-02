using System;
namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numeros = new int[15];

             for (int i = 0; i < 15; i++)
             {
                 Console.WriteLine("Ingrese el número " + i);
                 numeros[i] = int.Parse(Console.ReadLine());
             }

             int maximo = numeros[0];
             int minimo = numeros[0];

             for (int i = 1; i < 15; i++)
             {
                 if (numeros[i] > maximo) 
            {
            maximo = numeros[i];
            }
                 if (numeros[i] < minimo) 
            {
            minimo = numeros[i];
            }
             }

             Console.WriteLine("Máximo: " + maximo);
             Console.WriteLine("Mínimo: " + minimo);*/
            /*int tam = 5;
            int[] vector1 = new int[tam];
            int[] vector2 = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Vector1 - posición " + i);
                vector1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Vector2 - posición " + i);
                vector2[i] = int.Parse(Console.ReadLine());
            }

            int iguales = 0;
            for (int i = 0; i < tam; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    iguales++;
                }
            }

            Console.WriteLine("Elementos iguales en la misma posición: " + iguales);*/
            int tam = 6;
            char[] vector = new char[tam];
            char[] invertido = new char[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Ingrese carácter " + i);
                vector[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tam; i++)
            {
                invertido[i] = vector[tam - 1 - i];
            }

            Console.WriteLine("Vector original:");
            for (int i = 0; i < tam; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Vector invertido:");
            for (int i = 0; i < tam; i++)
            {
                Console.Write(invertido[i] + " ");
            }
        }
    }
}
