using Course;

namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500, 10);


            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //p.Quantidade = -10;

        }
    }
}