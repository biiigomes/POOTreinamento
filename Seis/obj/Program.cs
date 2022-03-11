using System;

namespace Seis
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(listaPessoa);

            Console.WriteLine(listaPessoa(max));

            foreach(Pessoa pessoa in listaPessoa){
                Console.WriteLine(pessoa.nome);            
            }

            Console.WriteLine(listaPessoas.Find(x => x.nome.Contains("Jessica")));

            if("Jessica" == true){
                Console.WriteLine(idade);
            }

        }
    }
}
