namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public IEnumerable<Album> Albuns => albuns; // puxa a lista de albuns para a propriedade albuns de somente leitura
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

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }


    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}