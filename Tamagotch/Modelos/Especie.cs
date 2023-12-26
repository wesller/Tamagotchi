using System.Text.Json.Serialization;

namespace Tamagotch.Modelos;

internal class Especie
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
