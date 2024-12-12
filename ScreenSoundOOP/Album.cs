class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        int counter = 1;
        Console.WriteLine("\n===================================================");
        Console.WriteLine($"Álbum: {Nome}");
        Console.WriteLine("===================================================");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"{counter}. {musica.Nome}");
            counter++;
        }
        Console.WriteLine($"\nDuração total: {DuracaoTotal} segundos");
    }
}
