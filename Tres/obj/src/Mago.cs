using Tres.obj.src;

namespace Tres.obj.src 
{
    public class Mago
    {
        List<Magia> magia = new ArrayList<Magia>();

        public Magos(){
            magia.add(m1);
            magia.add(m2);
            magia.add(m3);
            magia.add(m4);
        }

        public lvlUp(){
            switch(level){
                case 1: 
                  mana =+ 1;
                  inteligencia =+ 1;
                  XP =+ 1;

                case 2: 
                  mana =+ 2;
                  inteligencia =+ 2;
                  XP =+ 2;
                
                case 3: 
                  mana =+ 3;
                  inteligencia =+ 3;
                  XP =+3;
                
                case 4:
                  mana =+ 4;
                  inteligencia =+ 4;
                  XP =+ 4;
                
                case 5: 
                  mana =+ 5;
                  inteligencia =+5;
                  XP =+ 5;
                
                case 6: 
                  mana =+ 6;
                  inteligencia =+ 6;
                  XP =+ 6;
                
                case 7:
                  mana =+ 7;
                  inteligencia =+ 7;
                  XP =+ 7;
                
                case 8: 
                  mana =+8;
                  inteligencia =+8;
                  XP =+ 8;
            
                case 9:
                  mana =+ 9;
                  inteligencia =+9;
                  XP =+ 9;

                case 10: 
                  mana =+ 10;
                  inteligencia =+ 10;
                  XP =+ 10;

                break;
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