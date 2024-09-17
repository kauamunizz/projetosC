using System.Globalization;

namespace exercicio_class2 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario pessoa1, pessoa2;

            pessoa1 = new Funcionario();
            pessoa2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMedio = (pessoa1.Salario + pessoa2.Salario) / 2;

            Console.Write("Salario medio = " + SalarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
