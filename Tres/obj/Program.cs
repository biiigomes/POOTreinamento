using System;
using Tres.obj.src;

namespace Tres
{
    class Program
    {
        public static void Main(string[] args)
        {
            Magia m1 = new Magia("Priya", 10, 10, 9.0, 10, 9, 6);
            Magia m2 = new Magia("Blair", 8, 6, 4.0, 5, 7, 5);
            Magia m3 = new Magia("Syle", 8, 9, 6.7, 9, 4, 3);
            Magia m4 = new Magia("Octobos", 6, 8, 7.0, 3, 8, 4);

            Habilidade g1 = new Habilidade("Summer", 10, 10, 9.0, 5, 9, 6);
            Habilidade g2 = new Habilidade("Levi", 9, 8, 8.6, 9, 8, 5);
            Habilidade g3 = new Habilidade("Kuina", 7, 4, 7.5, 7, 7, 4);
            Habilidade g4 = new Habilidade("Autumn", 6, 8, 7.0, 5, 8, 3);


            Console.WriteLine("A quantidade de personagens é de: " + personagensTotal);
            
            m1.attack();
            m1.lvlUp();
            g1.attack();
            m1.lvlUp();

            foreach (nome nome in Personagem)
            {
                Console.WriteLine(nome);
            }

        }

        
    }
}