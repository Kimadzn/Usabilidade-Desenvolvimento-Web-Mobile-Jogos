using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Powerstats
    {
        [JsonPropertyName("intelligence")]
        public string Intelligence { get; set; } = string.Empty;

        [JsonPropertyName("strength")]
        public string Strength { get; set; } = string.Empty;

        [JsonPropertyName("speed")]
        public string Speed { get; set; } = string.Empty;

        [JsonPropertyName("durability")]
        public string Durability { get; set; } = string.Empty;

        [JsonPropertyName("power")]
        public string Power { get; set; } = string.Empty;

        [JsonPropertyName("combat")]
        public string Combat { get; set; } = string.Empty;
    }
}