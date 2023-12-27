using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tamagotch.Modelos;

internal class Mascote
{
    public List<AbilityWrapper> abilities {  get; set; }

    [JsonPropertyName("height")]
    public int Altura { get; set; }

    [JsonPropertyName("weight")]
    public int Peso { get; set; }
}
