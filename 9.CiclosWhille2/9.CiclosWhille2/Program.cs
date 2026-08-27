using System;

namespace _9.CiclosWhille2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int contador = 0;
            int Menores = 0;
            int iguales = 0;
            int mayores = 0;
            int num = 0;
            Console.WriteLine("cuantos numeros quieres ingresar?");
            cantidad = int.Parse(Console.ReadLine());
            while (cantidad > contador)
            {
                contador++;
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                   mayores++;
                }
                else
                {
                    if (num < 0)
                    {
                        Menores++;
                    }
                    else
                    {
                        iguales++;
                    }
                }
                
            }
            Console.WriteLine("Cantidad de numeros mayores a 0 " + mayores);
            Console.WriteLine("Cantidad de numeros menores a 0 " + Menores);
            Console.WriteLine("Cantidad de numeros iguales a 0 " + iguales);
        }
    }
}
