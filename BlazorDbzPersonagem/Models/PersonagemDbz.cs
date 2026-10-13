
using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models;

public class PersonagemDbz
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("originPlanet")]
    public PlanetaDbz? OriginPlanet { get; set; }

    [JsonPropertyName("transformations")]
    public List<TransformacaoDbz> Transformations { get; set; } = new();
}

public class PlanetaDbz
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
}

public class TransformacaoDbz
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
}
