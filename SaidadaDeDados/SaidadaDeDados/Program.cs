using System;
using System.Globalization;

namespace SaidaDeDados 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char gender = 'F';
            int idade = 24;
            double saldo = 2.34423;
            string nome = "Kaua";

            Console.WriteLine(gender);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}