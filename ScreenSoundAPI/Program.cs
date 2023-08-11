using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //Deserializa o Json para ser entendido pela aplicação em C#
        //LinqFilter.FitrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdernados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Justin Bieber");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Algo deu errado!\nErro: {ex.Message}");
    }
}