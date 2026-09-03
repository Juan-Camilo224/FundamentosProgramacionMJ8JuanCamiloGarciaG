using System;

namespace _12.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contador = 1;
            //int contador2 = 1;
            //int contadorDivisores = 0;

            //do
            //{
            //    do
            //    {
            //        contador2++;
            //        if (contador % contador2 == 0)
            //        {
            //            contadorDivisores++;
            //        }

            //    } while (contador2 <= contador);
            //    contador2 = 0;
            //    if (contadorDivisores == 2)
            //    {
            //        Console.WriteLine(contador);
            //    }
            //        contador++;
            //    contadorDivisores= 0;

            //} while (contador <= 100);
            bool repetir;
            int acumulador = 0;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = (Console.ReadLine());
                Console.WriteLine("Ingrese su numero de cuenta");
                int numcuenta= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                int saldo = int.Parse(Console.ReadLine());
                if (saldo<=3000000)
                {
                    Console.WriteLine(nombre + " " + numcuenta + "Es apto para el credito");
                } else
                {
                    Console.WriteLine(nombre + " " + numcuenta + "No es apto para el credito");
                }
                acumulador += saldo;
                contador++;
                Console.WriteLine("Desea volver a ingresar datos?(true/false)");
                repetir = bool.Parse(Console.ReadLine());
            } while (repetir ==  true);
            Console.WriteLine("se consultaron " + contador + ", el promedio de los saldos es " + (acumulador / contador));
        }
    }
}
