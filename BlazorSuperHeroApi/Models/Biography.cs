using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Biography
    {
        [JsonPropertyName("full-name")]
        public string FullName { get; set; } = string.Empty;

        [JsonPropertyName("alter-egos")]
        public string AlterEgos { get; set; } = string.Empty;

        [JsonPropertyName("aliases")]
        public List<string> Aliases { get; set; } = [];

        [JsonPropertyName("place-of-birth")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [JsonPropertyName("first-appearance")]
        public string FirstAppearance { get; set; } = string.Empty;

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; } = string.Empty;

        [JsonPropertyName("alignment")]
        public string Alignment { get; set; } = string.Empty;
    }
}