using System;

namespace Course
{
    class Program{
        static void Main(string[] args)
        {
            bool completo = false;
            char gender = 'F';
            sbyte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object objt1 = "Alex Brown";
            int teste = int.MinValue;

            Console.WriteLine(teste);
            Console.WriteLine(completo);
            Console.WriteLine(gender);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome); // imutavel (segurança, simplicidade e thread safe)
            Console.WriteLine(objt1);
        }
    }
}