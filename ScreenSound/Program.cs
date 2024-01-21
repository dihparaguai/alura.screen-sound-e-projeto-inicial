using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda ira = new("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(7));
Banda beatles = new("The Beatles");


Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new(); // adicionado todas as classes de opções do menu a um dicionario
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuRegistrarMusica());
opcoes.Add(4, new MenuMostrarBandasRegistradas());
opcoes.Add(5, new MenuAvaliarBanda());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(7, new MenuAvaliarMusica());
opcoes.Add(8, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para registrar o a musica de um album");
    Console.WriteLine("Digite 4 para mostrar todas as bandas");
    Console.WriteLine("Digite 5 para avaliar uma banda");
    Console.WriteLine("Digite 6 para avaliar um album");
    Console.WriteLine("Digite 7 para avaliar uma musica");
    Console.WriteLine("Digite 8 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    { 
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica]; // atribui ao tipo menu, a classe de menus esco
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu(); // só exibe o menu novamente se o valor digitado for maior que 0
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
    
}

ExibirOpcoesDoMenu();