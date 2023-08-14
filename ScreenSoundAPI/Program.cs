using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //Deserializa o Json para ser entendido pela aplicação em C#

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        /*
        --- TESTES --- 

        musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FitrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdernados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Justin Bieber");

        var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        musicasPreferidasDoDaniel.AdcionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDaniel.AdcionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoDaniel.AdcionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoDaniel.AdcionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoDaniel.AdcionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        var musicasPreferidasDaEmilly = new MusicasPreferidas("Emilly");
        musicasPreferidasDaEmilly.AdcionarMusicasFavoritas(musicas[500]);
        musicasPreferidasDaEmilly.AdcionarMusicasFavoritas(musicas[637]);
        musicasPreferidasDaEmilly.AdcionarMusicasFavoritas(musicas[428]);
        musicasPreferidasDaEmilly.AdcionarMusicasFavoritas(musicas[13]);
        musicasPreferidasDaEmilly.AdcionarMusicasFavoritas(musicas[71]);

        musicasPreferidasDaEmilly.ExibirMusicasFavoritas();

        musicasPreferidasDaEmilly.GerarArquivoJson();*/

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Algo deu errado!\nErro: {ex.Message}");
    }
}