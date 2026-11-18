using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class ImageInfo
    {
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}