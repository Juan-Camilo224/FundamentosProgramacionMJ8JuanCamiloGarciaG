using System;
using System.Diagnostics.Eventing.Reader;
namespace Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int numero1 = 0;
             int numero2 = 0;
             int numero3 = 0;
             int mayor = 0;
             int medio = 0;
             int menor = 0;
             Console.WriteLine("Ingrese el numero 1");
             numero1=int .Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el numero 2");
             numero2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el numero 3");
             numero3 = int.Parse(Console.ReadLine());
             if (numero1 > numero2 && numero1 > numero3)
             {
                 Console.WriteLine(numero1 + " es mayor");
                 mayor = numero1;
                 if (numero2 > numero3)
                     medio = numero2;
                 menor = numero3;
                 Console.WriteLine("1. " + mayor + " 2. " + medio + " 3. " + menor);
             }
             if (numero2 > numero1 && numero2 > numero3)
             {
                 Console.WriteLine(numero2 + " es mayor");
                 mayor = numero2;
                 if (numero1 > numero3)
                     medio = numero1;
                 menor = numero3;
                 Console.WriteLine("1. " + mayor + " 2. " + medio + " 3. " + menor);
             }
             if (numero3 > numero2 && numero3 > numero1)
             {
                 Console.WriteLine(numero3 + " es mayor");
                 mayor = numero3;
                 if (numero2 > numero1)
                     medio = numero2;
                 menor = numero1;
                 Console.WriteLine("1. " + mayor + " 2. " + medio + " 3. " + menor);
             }
             if (numero1 == numero2 && numero2 == numero3 && numero3 == numero1)
             {
                 Console.WriteLine("Ingresar numeros diferentes");
             }*/
            int balas;
            Random rnd = new Random();
            balas = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
            Console.WriteLine(balas);
        }      
        }
    }