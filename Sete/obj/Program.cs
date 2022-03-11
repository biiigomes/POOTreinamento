using System;
using Sete.obj.src;

namespace Sete
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Tatiana", 40, 10.000);
            Supervisor supervisor = new Supervisor("Edson", 35, 5.000 );
            Vendedor vendedor = new Vendedor("Olga", 50, 1.000);

            Console.WriteLine(gerente);
            gerente.bonificacao();

            Console.WriteLine("--------------");

            Console.WriteLine(supervisor);
            supervisor.bonificacao();

            Console.WriteLine("--------------");

            Console.WriteLine(vendedor);
            vendedor.bonificacao();

            Console.WriteLine("--------------");

        }
    }
}
