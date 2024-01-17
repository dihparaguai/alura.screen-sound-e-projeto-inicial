namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse (string texto) // funcao estatica que cria um objeto desta mesma classe
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
