using System;

namespace ConversaoImplicitaECasting 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a;

            //Console.WriteLine(b);

            //double c;
            //int d;

            //c = 5.1;
            //d = (int)c;

            //Console.WriteLine(d);

            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado);
        }
    }
}