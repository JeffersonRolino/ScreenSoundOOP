Episodio episodio1 = new Episodio(3, "Técnicas de Facilitação", 45);
episodio1.AdicionarConvidados("Maria");
episodio1.AdicionarConvidados("Pedro");
episodio1.AdicionarConvidados("João");

Episodio episodio2 = new Episodio(2, "Introdução ao Javascript", 67);
episodio2.AdicionarConvidados("Marcos");
episodio2.AdicionarConvidados("Fernanda");

Episodio episodio3 = new Episodio(1, "Técnicas de Aprendizado", 123);
episodio3.AdicionarConvidados("José");
episodio3.AdicionarConvidados("Maurício");
episodio3.AdicionarConvidados("Tales");

Podcast podcast = new Podcast("Codecast", "Daniel Souza");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);

podcast.ExibirDetalhes();