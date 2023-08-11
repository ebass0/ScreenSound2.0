using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]      //Atributo que especifica um metadado da API
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 100} segundos");
        Console.WriteLine($"Gênero musical: {Genero}");
    }
}
