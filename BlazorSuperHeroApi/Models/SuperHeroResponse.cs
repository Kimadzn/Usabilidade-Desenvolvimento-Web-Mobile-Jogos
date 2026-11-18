using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHeroResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;

        [JsonPropertyName("results-for")]
        public string ResultsFor { get; set; } = string.Empty;

        [JsonPropertyName("results")]
        public List<SuperHero>? Results { get; set; }
    }
}