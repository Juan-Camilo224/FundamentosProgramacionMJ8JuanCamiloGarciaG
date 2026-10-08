using System;
namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de programacion");
            Console.WriteLine("Ferney");
            Console.WriteLine($"Ferney tiene {CalcularEdad()}");
            Console.WriteLine("Camilo");
            int añonacimiento = 2000;
            int añoActual = 2026;
            Console.WriteLine($"Camilo tiene, {CalcularEdad(añonacimiento,añoActual)} años"); 
            MostrarMensaje("Ferney", "Chica Álvarez"); 
            Console.ReadKey();
            BorrarPantalla();
        }

            static int CalcularEdad(int añoActual, int añoNacimiento)
            {
                return añoActual - añoNacimiento;
            }
            static int CalcularEdad()
            {
                int añoNacimiento = 2008;
                int añoActual = 2026;
                int edad = añoActual - añoNacimiento;
                return edad;
            }

        static void BorrarPantalla()
        {
            Console.Clear();
        }
            static void MostrarMensaje(string nombre)
            {
                Console.WriteLine($"Bienvenido, {nombre} al curso de fundamentos de programación");
            }
            static void MostrarMensaje(string nombre, string apellidos)
            {
                Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de fundamentos de programación");
            }
        }
    }

