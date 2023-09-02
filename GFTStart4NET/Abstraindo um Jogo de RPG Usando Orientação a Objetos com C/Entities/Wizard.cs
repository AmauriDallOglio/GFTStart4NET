namespace GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }

        public override string Attack()
        {
            return this.Name + "Lançou magia ";
        }

        public string TypeAttack(int Bonus)
        {
            string descricao = "";
            switch (Bonus)
            {
                case 1:
                    descricao = DescricaoMagia(1, 1);
                    break;
                case 2:
                    descricao = DescricaoMagia(2, 2);
                    break;
                case 3:
                    descricao = DescricaoMagia(3, 3);
                    break;
                case 4:
                    descricao = DescricaoMagia(4, 4);
                    break;
                case 5:
                    descricao = DescricaoMagia(5, 5);
                    break;
                case 6:
                    descricao = DescricaoMagia(6, 6);
                    break;
                case 7:
                    descricao = DescricaoMagia(7, 7);
                    break;
                case 8:
                    descricao = DescricaoMagia(8, 8);
                    break;
                case 9:
                    descricao = DescricaoMagia(9, 9);
                    break;
                case 10:
                    descricao = DescricaoMagia(10, 10);
                    break;
                default:
                    return this.Name + "Magia " + Bonus;
            }
            return descricao;

        }

        private string DescricaoMagia(int Bonus, int dano)
        {
            string descriacao = "Magia do nível " + Bonus + ", dano " + dano + " ponto!";
            return descriacao;

        }

        public string Attack(int Bonus)
        {
            switch (Bonus)
            {
                case 1:
                default:
                    break;
            }


            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia com força fraca com bonus de " + Bonus;
            }
        }


    }
}
