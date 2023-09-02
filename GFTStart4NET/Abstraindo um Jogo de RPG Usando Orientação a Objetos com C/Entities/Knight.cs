using System.Runtime.CompilerServices;

namespace GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }

        public string HistoriaAragorn()
        {
            return "Aragorn nasceu no dia 1 de Março de 2931, na Terceira Era, filho de Arathorn II e Gilraen.";
        }
 
    }
}
