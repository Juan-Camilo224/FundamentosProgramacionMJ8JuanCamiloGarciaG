using System;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Numero = new Random();
            int Num= Numero.Next(1,101);
            int NumH =-1;
            Console.WriteLine("Adivina el numero que escogi");
            while (Num != NumH) 
            {
                NumH=int.Parse(Console.ReadLine());
                if (NumH > Num)
                {
                    Console.WriteLine("Demasiado alto");
                }
                if (NumH < Num)
                {
                    Console.WriteLine("Demasiado bajo");
                }
            }
            Console.WriteLine("Acertaste");
        }
    }
}
