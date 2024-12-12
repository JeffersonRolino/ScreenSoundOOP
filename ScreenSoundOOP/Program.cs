Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

// Adicionando músicas ao Álbum;
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

// Exibindo Álbum
albumDoQueen.ExibirMusicasDoAlbum();


// Exibir Músicas
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

// Adicionando Álbum a Banda
queen.AdicionarAlbum(albumDoQueen);
// Exibir Discografia da Banda
queen.ExibirDiscografia();