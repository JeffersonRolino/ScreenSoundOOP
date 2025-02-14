﻿class Musica
{
    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("\n===================================================");
        Console.WriteLine("Música");
        Console.WriteLine("===================================================");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus para acessar essa música");
        }
    }
}
