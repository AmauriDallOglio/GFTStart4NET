namespace GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities
{
    public  class Villain
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoits;
        public int MagicPoits;

        public Villain()
        {

        }

        public Villain(string Name, int Level, string HeroType, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }


        public override string ToString()
        {
            return this.Name + " Level: " + this.Level + " Tipo: " + this.HeroType + " Vida: " + this.HealthPoits + " Força: " + this.MagicPoits;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada!";
        }
    }
}
