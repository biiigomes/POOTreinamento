using System;

namespace Treinamento.Src
{
    public class Veiculos
    {
        public object desligado;
        public bool pintado;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado {  get; set; }
        public int litrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set;}
        public int Combustivel { get; set; }

        public Veiculos(string Marca, string Modelo, string Placa, string Cor, float Km, bool isLigado, int litrosCombustivel, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Km = Km;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            this.Preco = Preco;
        }

        public double Acelerar()
        {
            this.Velocidade =+ 20;
            return Velocidade;
        }

        public double Abastecer()
        {         
            if (this.litrosCombustivel == 60){
                Console.WriteLine("O carro está abastecido");
            } else {
                this.litrosCombustivel =+ Combustivel;
            }
            return litrosCombustivel;
        }

        public double Frear()
        {
            if((bool)(desligado = true))
            {
                Console.WriteLine("O carro está parado");
            } else {
                Velocidade =- 20;
            }
            return this.Velocidade;
        }

        public double Pintar()
        {
            if(pintado == true){
                Console.WriteLine("Repintando o carro");
            } else {
                Console.WriteLine("Continua da mesma cor");
            }
            double novaCor = Convert.ToDouble(Cor);
            return novaCor;
        }
        
        public double Ligar()
        {
            if(this.isLigado == true){
                Console.WriteLine("O carro está ligado");
            } else{
                Console.WriteLine("Ligando o carro");
            }

            double Ligado = Convert.ToDouble(isLigado);
            return Ligado;
        }

        public bool Desligar()
        {
            if(this.Velocidade > 0){
                Console.WriteLine("O carro está desligado");
            } else {
                Console.WriteLine("Desligando o carro");
            }
            return (bool)desligado;
        }

        public override string ToString(){
            return "Carro: " + this.Marca + "\n"
            + "Modelo: " + this.Modelo + "\n"
            + "Placa: " + this.Placa + "\n"
            + "Cor: " + this.Cor + "\n"
            + "Quilometragem: " + this.Km + "\n"
            + "Combustivel: " + this.litrosCombustivel + "\n"
            + "Preco: " + this.Preco;
        }
    }

}
    