using System;
using Treinamento.Src;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculos carro = new Veiculos("Honda", "Civic", "RE3", "Preto", 37,  false, 48, 3.974);
            
            Console.WriteLine(carro);
            Console.WriteLine("----------------");

            carro.Abastecer();
            carro.Acelerar();
            carro.Frear();
            carro.Desligar();
            carro.Ligar();
            carro.Pintar();

            Console.WriteLine("---------------");
        }

    }
}
