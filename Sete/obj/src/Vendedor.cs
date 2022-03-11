namespace Sete.obj.src
{
    public class Vendedor: Funcionario
    {
        public bonificacao(string nome, int idade, float salario){
            return salario =+ 3000.00;
        }

        public override string ToString(){
            return "Nome: " + this.nome + "\n"
            + "Idade: " + this.idade + "\n"
            + "Salário: " + this.salario;
        }
    }
}