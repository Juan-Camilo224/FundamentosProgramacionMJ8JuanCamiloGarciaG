using System;
using System.Security.Cryptography;

namespace _15.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            //encuentre y muestre el valor máximo y mínimo de los números ingresados.
            int[] numero = new int[15];
            int mayor = 0;
            int menor = 0;
            for (int i = 0; i < 15; i++)
            {

                Console.WriteLine("ingrese un numero");
                numero[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = numero[i];
                    mayor = numero[i];
                }
                if (numero[i] < menor)
                {
                    mayor = numero[i];
                }
                if (numero[i] > mayor)
                {
                    mayor = numero[i];
                }
            }
            Console.WriteLine("El mayor es " + mayor + " y el menor es " + menor);


        }

    }
}
