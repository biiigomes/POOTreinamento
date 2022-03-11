namespace Cinco.obj.src
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        Pessoa p1 = new Pessoa("João", 15);
        Pessoa p2 = new Pessoa("Leandro", 21);
        Pessoa p3 = new Pessoa("Paulo", 17);
        Pessoa p4 = new Pessoa("Jessica", 18);


        List<Pessoa> listaPessoas = new ArrayList<>();
        Pessoa.add p1;
        Pessoa.add p2;
        Pessoa.add p3;
        Pessoa.add p4;
    }
}