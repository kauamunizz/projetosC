using Course;

namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500, 10);


            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            //p.Quantidade = -10;

        }
    }
}
