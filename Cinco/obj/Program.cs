using System;
using Cinco.obj.src;

namespace Cinco
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(listaPessoas);

            Console.WriteLine(listaPessoas(max));

            foreach(Pessoa pessoa in listaPessoa){
                Console.WriteLine(pessoa.nome);            
            }
            if(idade < 18){
                listaPessoas.Remove();
            }

            Console.WriteLine(listaPessoas);
        }
    }
}
