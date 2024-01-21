namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Avaliacao> notas = new();
    private List<Musica> musicas = new();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota); // calcula a média das notas que estão dentro da var/prop "notas" da lista do tipo "Avaliacao", usando a expressão lambda a => a.Nota para percorrer cada "Nota" do objeto "Avaliacao"
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}