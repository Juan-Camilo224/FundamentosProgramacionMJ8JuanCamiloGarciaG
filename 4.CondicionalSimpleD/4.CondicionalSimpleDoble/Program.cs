using System;


namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estructura de control tradicional
            //Simple
            // 1. Crea un algoritmo que lea la edad de un usuario; si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web".
            /*      byte edad = 0;
                  Console.WriteLine("ingrese su edad");
                  edad = Convert.ToByte (Console.ReadLine());
                  if (edad >= 18)
                  {
                      // Si la condicion es verdadera
                      Console.WriteLine("Bienvenido a mi sitio web");
                  }*/
            /* decimal sueldo = 0;
             string nombre = null;
             Console.WriteLine("Ingrese su nombre");
             nombre = (Console.ReadLine());
             Console.WriteLine("ingrese su sueldo");
             sueldo = Convert.ToDecimal(Console.ReadLine());
             if (sueldo > 3000)
             {
                 Console.WriteLine(nombre + " Debes abonar impuestos");
             }*/
            byte edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                // Si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido del sitio web");
            }
        }
    }

}

