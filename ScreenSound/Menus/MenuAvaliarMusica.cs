using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarMusica : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar Musica");
            Console.Write("Digite o nome da banda que deseja avaliar: "); // primeiro, capturamos o nome da banda
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda)) // se banda existir...
            {
                Banda banda = bandasRegistradas[nomeDaBanda]; // colocamos todo o objeto da banda encontrada dentro de uma var
                Console.Write("Agora digite o nome do album: "); // segundo, capturamos o nome do album
                string tituloAlbum = Console.ReadLine()!;
                if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum))) // se album exsitir...
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum)); // colocamos todo o objeto do album encontrado dentro de uma var
                    Console.Write("Agora digite o nome da musica: "); // terceiro, capturamos o nome da musica
                    string nomeMusica = Console.ReadLine()!;
                    if (album.Musicas.Any(a => a.Nome.Equals(nomeMusica))) // se musica esxitir
                    {
                        Musica musica = album.Musicas.First(a => a.Nome.Equals(nomeMusica)); // colocamos todo o objeto da musica encontra dentro de uma var
                        Console.Write($"Qual a nota que a musica {nomeMusica} merece: ");
                        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!); // chama um metodo estatico que cria um objeto do mesmo tipo
                        musica.AdicionarNota(nota);
                        Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a musica {nomeMusica}");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"\nA musica {nomeMusica} não foi encontrada!");
                        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
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
}
