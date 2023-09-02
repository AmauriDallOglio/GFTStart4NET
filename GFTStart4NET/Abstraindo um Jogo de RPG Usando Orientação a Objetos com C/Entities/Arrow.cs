namespace GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities
{
    public class Arrow : Hero
    {
        public Arrow(string Name, int Level, string HeroType, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }
    }
}
