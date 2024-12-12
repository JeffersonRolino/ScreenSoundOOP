class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine("\n===================================================");
        Console.WriteLine($"Discografia da banda {Nome}");
        Console.WriteLine("===================================================");
        foreach (Album album in albums)
        {
            Console.WriteLine(album.Nome);
        }
    }
}
