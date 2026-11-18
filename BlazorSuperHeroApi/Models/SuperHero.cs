using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHero
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("powerstats")]
        public Powerstats Powerstats { get; set; } = new();

        [JsonPropertyName("biography")]
        public Biography Biography { get; set; } = new();

        [JsonPropertyName("appearance")]
        public Appearance Appearance { get; set; } = new();

        [JsonPropertyName("work")]
        public Work Work { get; set; } = new();

        [JsonPropertyName("connections")]
        public Connections Connections { get; set; } = new();

        [JsonPropertyName("image")]
        public ImageInfo Image { get; set; } = new();
    }
}