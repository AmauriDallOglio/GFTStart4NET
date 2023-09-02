namespace GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, string HeroType, int Level, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada especial.";
        }
    }
}
