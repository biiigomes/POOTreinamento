namespace Dois.obj.Src.model
{
    public class Livro
    {
        public string autor { get; set; }
        public string tema { get; set; }
        public int qtdPag { get; set; }

        Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public override string ToString(){
            return "Nome: " + this.nome + "\n"
            + "Preco: " + this.preco + "\n"
            + "Quantidade: " + this.qtd + "\n"
            + "Autor: " + this.autor + "\n"
            + "Número de páginas: " + this.qtdPag;
        }
    }
}