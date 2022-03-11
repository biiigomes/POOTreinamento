namespace Dois.obj.Src.model
{
    public class VideoGame
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public bool isUsado { get; set; }

        VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public override string ToString(){
            return "Nome: " + this.nome + "\n"
            + "Preco: " + this.preco + "\n"
            + "Quantidade: " + this.qtd + "\n"
            + "Marca: " + this.marca + "\n"
            + "Modelo: " + this.modelo + "\n"
            + "Usado? " + this.modelo;
        }
    }
}