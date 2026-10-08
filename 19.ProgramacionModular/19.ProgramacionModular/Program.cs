using System;
namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mostrarmenu();
          
            RealizarOperaciones(CapturarOpcion());
        }
        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando (s: continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            return suma;
            
        }
        static float Division()
        {
            Console.WriteLine("ingrese el numero1: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2:");
            float numero2 = char.Parse(Console.ReadLine());
            return numero1 / numero2;
        }
        static float Resta()
        {
                Console.WriteLine("ingrese el numero1: ");
            float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero2:");
                float numero2 = char.Parse(Console.ReadLine());
            return numero1 - numero2;
        }
        static float Multiplicacion()
        {
            float multiplicacion = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir sumando (s: continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            return multiplicacion;
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion!=0) 
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La Suma de los numeros ingresados es {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los numeros ingresados es {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La Multiplicacion de los numeros ingresados es {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La division de los numeros ingresados es {Division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Mostrarmenu();
                opcion = CapturarOpcion();
            }
        }
        static void Mostrarmenu()
        {
            Console.WriteLine("------------MENU------------");
            Console.WriteLine("1.Suma            2.Resta");
            Console.WriteLine("3.Multiplicacion  4.Division");
            Console.WriteLine("0.Salir");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ingrese una opcion del menu");
        }
        static int CapturarOpcion()
        {   
            return int.Parse(Console.ReadLine());
        }
    }
}
