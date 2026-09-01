using System;
namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 0;
            dato1++; //++=dato1+1
            dato1--; //--= dato1
            dato1 += 5; //dato1=dato1+5 incremento en 5 uds
            dato1 *= 3; //dato1 =dato1*3;
            dato1 /= 2; //dato1 = dato1/2
            dato1 += dato1;

            //orden de evaluación de operadores numéricos: 
            float dato2 = 4 / 3 * 2;
            float dato3 = 4 * (2 / 3);
            float dato4 = 4 + 6 * 2;
            float dato6 = 4 + 6 * (2 - 1);
            float dato5 = dato2 * dato3 - dato4 / dato6;
            //operadores lógicos
            //conjunción - and - Y -- &&
            Console.WriteLine("-------------------TABLA DE LA CONJUNCIÓN---------------------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("---------------------------------------------------------------");

            //disyunción - OR - O -||
            Console.WriteLine("------------------TABLA DE LA DISYUNCIÓN-----------------------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("---------------------------------------------------------------");
            //Negación - NO - N - !
            Console.WriteLine("------------------TABLA DE LA DISYUNCIÓN-----------------------");
            Console.WriteLine("!V =" + (!true));
            Console.WriteLine("!F" + (!false));
            Console.WriteLine("---------------------------------------------------------------");

            bool dato7 = true;
            bool dato8 = !dato7;
            int sixseven = 67;

            //operadores de comparación
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 67 == sixseven;
            bool dato13 = 5 < 4 && dato7;
            bool dato14 = 9 == 1 || 12 > 3 && dato9;

        }
    }
}
