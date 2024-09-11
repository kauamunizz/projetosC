using System;
using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite uma frase:");

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string a = Console.ReadLine();
            //string[] vet = a.Split(' '); //Slpit é o divisor
            ////string[] vet = Console.ReadLine().Split(' ');

            //string b = vet[0];
            //string c = vet[1];
            //string d = vet[2];



            //Console.WriteLine("Voce digitou:");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);


            //int n1 = int.Parse(Console.ReadLine());
            ////Parse converte string para inteiro
            //Console.WriteLine(n1);

            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine(ch);

            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(n2);

            string[] pessoa = Console.ReadLine().Split(' ');
            string nome = pessoa[0];
            char sexo = char.Parse(pessoa[1]);
            int idade = int.Parse(pessoa[2]);
            double altura = double.Parse(pessoa[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}