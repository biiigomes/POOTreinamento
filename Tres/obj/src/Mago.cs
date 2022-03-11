using Tres.obj.src;

namespace Tres.obj.src 
{
    public class Mago
    {
        Magia m1 = new Magia("Priya", 10, 10, 9.0, 10, 9, 6);
        Magia m2 = new Magia("Blair", 8, 6, 4.0, 5, 7, 5);
        Magia m3 = new Magia("Syle", 8, 9, 6.7, 9, 4, 3);
        Magia m4 = new Magia("Octobos", 6, 8, 7.0, 3, 8, 4);
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
                  XP =+ 4;
                
                case 6: 
                  mana =+ 6;
                  inteligencia =+ 6;
                  XP =+ 4;
                
                case 7:
                  mana =+ 7;
                  inteligencia =+ 7;
                  XP =+ 4;
                
                case 8: 
                  mana =+8;
                  inteligencia =+8;
                  XP =+ 4;
            
                case 9:
                  mana =+ 9;
                  inteligencia =+9;
                  XP =+ 4;

                case 10: 
                  mana =+ 10;
                  inteligencia =+ 10;
                  XP =+ 4;
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