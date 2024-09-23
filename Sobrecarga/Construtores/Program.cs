using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            //Produto p = new Produto("TV", 500, 10);

            //Console.WriteLine(p);
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            /*sintaxe alternativa*/
            Produto p2 = new Produto { 
                Nome = "TV", 
                Preco = 1000, 
                Quantidade = 0 
            };

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }
}