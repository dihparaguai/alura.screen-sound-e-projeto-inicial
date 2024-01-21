using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas); // executa herença Menu
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!; // captura o nome da banda 
        if (bandasRegistradas.ContainsKey(nomeDaBanda)) // verifica se a banda existe
        {
            Banda banda = bandasRegistradas[nomeDaBanda]; // se existir, passa o objeto para uma var
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}."); // exibe a nota media da banda
            if (banda.Albuns.Count() > 0) // verifica se existe albuns...
            {   
                Console.WriteLine("\nDiscografia:");
                foreach (Album album in banda.Albuns)
                {
                    Console.WriteLine($"Album: {album.Nome} ==> {album.Media}"); // se existir, mostra todos os albuns e suas notas
                    if (album.Musicas.Count() > 0) // verifica se existe musica, dentro do album atual do foreach...
                    {
                        Console.WriteLine("\nMusicas: ");
                        foreach (Musica musica in album.Musicas)
                        {
                            Console.WriteLine($"{musica.Nome} ==> {musica.Media}");
                        }
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
