namespace Dois.obj.Src.Interface
{
    public interface Imposto
    {
        CalculaImpostoLivro()
        {
            if (tema == educativo){
                imposto == 0;
            } else {
                imposto = 10.0 / 100.0;
            }
            
        }

        CalculaImpostoGame()
        {
            if(isUsado == true){
                imposto = 25.0 / 100.0;
            } else{
                imposto = 45.0 / 100.0;
            }
        }
    }
}