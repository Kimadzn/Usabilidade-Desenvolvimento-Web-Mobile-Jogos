using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Work
    {
        [JsonPropertyName("occupation")]
        public string Occupation { get; set; } = string.Empty;

        [JsonPropertyName("base")]
        public string Base { get; set; } = string.Empty;
    }
}