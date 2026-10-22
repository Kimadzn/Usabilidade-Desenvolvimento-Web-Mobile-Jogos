using System.Text.Json.Serialization;

public class PokemonModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("sprites")]
    public SpritesModel Sprites { get; set; } = new();
}

public class SpritesModel
{
    [JsonPropertyName("other")]
    public OtherModel Other { get; set; } = new();
}

public class OtherModel
{
    [JsonPropertyName("official-artwork")]
    public OfficialArtworkModel OfficialArtwork { get; set; } = new();
}

public class OfficialArtworkModel
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;
}