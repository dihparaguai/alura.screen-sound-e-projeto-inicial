using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de Musicas");
        Console.Write("Digite o nome da banda que contem o álbum para registar a musica: "); // captura o nome da banda
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda)) // se banda existir
        {
            Console.Write("Agora digite o título do álbum para registar a musica: "); // captura nome do album da banda
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum))) // se album da banda existir
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write("Agora digite o nome da musica que deseja registrar: "); // captura nome da musica do album da banda qie será registrado
                string nomeMusica = Console.ReadLine()!;
                album.AdicionarMusica(new Musica(nomeMusica, banda));
                Console.WriteLine($"A musica {nomeMusica} do álbum {tituloAlbum} de {nomeDaBanda} foi registrada com sucesso!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"\nO Album {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
        }
        Console.Clear();
    }
}
