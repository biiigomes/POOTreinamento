using Tres.obj.src;

namespace Tres.obj.src
{
    public class Guerreiro
    {
        Habilidade g1 = new Habilidade("Summer", 10, 10, 9.0, 5, 9, 6);
        Habilidade g2 = new Habilidade("Levi", 9, 8, 8.6, 9, 8, 5);
        Habilidade g3 = new Habilidade("Kuina", 7, 4, 7.5, 7, 7, 4);
        Habilidade g4 = new Habilidade("Autumn", 6, 8, 7.0, 5, 8, 3);
        List<Habilidade> habilidade = new ArrayList<Habilidade>();

        public Guerreiros(){
            habilidade.add(g1);
            habilidade.add(g2);
            habilidade.add(g3);
            habilidade.add(g4);
        }

        public lvlUp(){
            switch(level){
                case 1: 
                  vida =+ 1;
                  forca =+ 1;

                case 2: 
                  vida =+ 2;
                  forca =+ 2;
                
                case 3: 
                  vida =+ 3;
                  forca =+ 3;
                
                case 4:
                  vida =+ 4;
                  forca =+ 4;
                
                case 5: 
                  vida =+ 5;
                  forca =+5;
                
                case 6: 
                  vida =+ 6;
                  forca =+ 6;
                
                case 7:
                  vida =+ 7;
                  forca =+ 7;
                
                case 8: 
                  vida =+8;
                  forca =+8;
            
                case 9:
                  vida =+ 9;
                  forca =+9;

                case 10: 
                  vida =+ 10;
                  forca =+ 10;
            }
        }

        public override string ToString(){
            return "Nome: " + this.nome + "\n"
            + "Vida: " + this.vida + "\n"
            + "Mana: " + this.mana + "\n"
            + "XP: " + this.XP + "\n"
            + "Inteligencia: " + this.inteligencia + "\n"
            + "Forca: " + this.forca + "\n"
            + "Level: " + this.level;

        }
    }
}