using System;
using System.Security;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int contador = 1;
            //    int acumulador = 1;
            //    while (contador < 5)
            //    {
            //        contador++;
            //        acumulador = acumulador + contador;
            //    }
            //    Console.WriteLine($"La suma de los primeros 5 numeros enteros es:"+ acumulador);

            int acumulador = 1;
            int contador = 1;
            int numero = 1;
            Console.WriteLine("Escriba un numero entero");
            numero =int.Parse(Console.ReadLine());
            while (contador > numero)
            {
                contador++;
                acumulador = acumulador * contador;
            }
            Console.WriteLine(numero +" factorial es " + acumulador);
        }
    }
}
