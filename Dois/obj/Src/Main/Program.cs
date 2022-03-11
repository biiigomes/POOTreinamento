using System;
using Dois.obj.Src.model;
using Dois.obj.Src.Interface;

namespace Dois
{
    class Program
    {
        static void Main(string[] args)
        {

            Livro l1 = new Livro("Harry Potter", 40, 50, "J.K.Rowling", 300);
            Livro l2 = new Livro("Senhor dos Aneis", 60, 30, "J.R.R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);
            
            ps4.CalculaImpostoGame();
            ps4Usado.CalculaImpostoGame();

            Console.WriteLine(ps4);
            Console.WriteLine(ps4Usado);

            Loja americanas = new Loja("Americanas", "123456", livros, games);
            l2.CalculaImpostoLivro();
            l3.CalculaImpostoGame();

            Console.WriteLine(americanas);
            americanas.listaLivros();
            americanas.listaVideoGame();
            americanas.calculaPatrimonio();

        }
    }
}
