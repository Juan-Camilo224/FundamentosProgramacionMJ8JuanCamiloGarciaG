using System;

namespace _8.CiclosWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume,
            //hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.
            int SumaEnterosPositivos = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un numero para sumar. Ingrese -1 para terminar");
            numero = int.Parse(Console.ReadLine());
            while (numero > 0)
            {
                SumaEnterosPositivos += numero;
                Console.WriteLine("Ingrese un numero para sumar. Ingrese -1 para terminar");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("la suma de los numeros positivos ingresados es: " + SumaEnterosPositivos);

        }
    }
}
