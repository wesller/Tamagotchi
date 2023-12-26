using System.Text.Json.Serialization;
namespace Tamagotch.Modelos;


internal class EspeciePacote
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public Especie[] Especies { get; set; }
}
