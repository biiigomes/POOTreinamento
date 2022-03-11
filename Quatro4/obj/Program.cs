using System;
using Quatro4.obj.src;

namespace Quatro4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine(Pessoa(max));

            foreach(Pessoa pessoa in listaPessoa){
                Console.WriteLine(pessoa.nome);            
            }
        }
    }
}
