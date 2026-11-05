
using System.Text.Json.Serialization;

namespace SearchDemonSlayerAPI.Models;

public class Character
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("age")]
    public int? Age { get; set; }

    [JsonPropertyName("race")]
    public string Race { get; set; } = string.Empty;

    [JsonPropertyName("quote")]
    public string Quote { get; set; } = string.Empty;

    [JsonPropertyName("img")]
    public string Img { get; set; } = string.Empty;
}
