namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota > 10) Nota = 10;
        else if (nota < 0) Nota = 0;
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse (string texto) // funcao estatica que cria um objeto desta mesma classe
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
