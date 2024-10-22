using System.Globalization;

namespace exercicio_fixacacao {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial na conta (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valro do deposito inicial: ");
                double depositoInbicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria (numero, nome, depositoInbicial);
            }
            else{
                 conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);
        }
    }
}
