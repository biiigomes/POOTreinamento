namespace Dois.obj.Src.model
{
    public class Loja
    {
        string nome { get; set; }
        string cnpj { get; set; }
        list<Livro>Livros;
        list<VideoGame>videoGames;
        public Loja(string nome, string cnpj, list<Livro>Livros, list<VideoGame>videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
        }

        public listaLivros()
        {
            Livros.add(l1);
            Livros.add(l2);
            Livros.add(l3);
        }

        public listaVideoGames()
        {
            videoGames.add(ps4);
            videoGames.add(ps4Usado);
            videoGames.add(xbox);
        }

        public calculaPatrimonio()
        {
            somaLivros = sum(Livros);
            somaGames = sum(videoGames);
            total = somaLivros + somaGames;
        }
    }
}