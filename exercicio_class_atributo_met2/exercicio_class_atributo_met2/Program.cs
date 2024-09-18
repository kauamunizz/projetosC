namespace exercicio_class_atributo_met2 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do Funcionario:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o salario:");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.Aumentarsalario(porcentagem);

            Console.WriteLine("Dados Atualizados" + funcionario);


        }
    }
}
