namespace Tres.obj.src
{
    public static class Personagem
    {
        string nome { get; set; }
        int vida { get; set; }
        int mana { get; set; }
        float XP { get; set; }
        int inteligencia { get; set; }
        int forca { get; set; }
        int level { get; set; }

        public Personagem(string nome, int vida, int mana, float XP, int inteligencia, int forca, int level)
        {
            this.nome = nome;
            this.vida = vida;
            this.mana = mana;
            this.XP = XP;
            this.inteligencia = inteligencia;
            this.forca = forca;
            this.level = level;
        }

        public attack(){
            Random randNum = new Random(0, 300);
            Mago = (inteligencia * level) + randNum;
            Guerreiro = (forca * level) + randNum;

            Console.WriteLine("Atacando o inimigo!");

        }

        public Contando()
        {
            foreach (nome nome in Personagem)
            {
                personagensTotal = +1;
            }

        }
    }
}