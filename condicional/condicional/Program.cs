using System;

namespace Condicional // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um numero inteirto");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Seu numero é par: " + x);
            //}
            //else
            //{
            //    Console.WriteLine("Seu numero é impar: " + x);
            //}

            Console.WriteLine("Qual sua hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18) // (12 <= hora && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

        }
    }
}