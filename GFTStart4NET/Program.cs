
using GFTStart4NET.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.Entities;

string opcao = string.Empty;
bool exibirMenu = true;

 

Knight heroAragorn = new Knight("Aragorn", 100, "Guerreiro", 5, 0);
Arrow heroLegolas = new Arrow("Legolas", 100, "Guerreiro", 5, 0);
Knight heroBilbo = new Knight("Bilbo", 100, "Hobbit", 5, 0);
Wizard heroGandalf = new Wizard("Gandalf", 100, "Wizard", 5, 100);
Knight oponnetGollum = new Knight("Gollum", 20, "Hobbit", 5, 0);
Wizard oponnetSauron = new Wizard("Sauron", 100, "Wizard", 5, 100);

List<Hero> personagens = new List<Hero>();
personagens.Add(heroAragorn);
personagens.Add(heroLegolas);
personagens.Add(heroBilbo);
personagens.Add(heroGandalf);
personagens.Add(oponnetGollum);
personagens.Add(oponnetSauron);



while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    for (int i = 0; i < personagens.Count; i++)
    {
        string opcoes = i.ToString() + " para " + personagens[i].Name;
        Console.WriteLine(opcoes);
    }
    Console.WriteLine("Digite 7 para sair");

    var digito = Console.ReadLine();
    switch (digito)
    {
        case "0":
            Console.WriteLine(heroAragorn.ToString());
            Console.WriteLine(heroAragorn.HistoriaAragorn());
            break;

        case "7":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

 
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");


