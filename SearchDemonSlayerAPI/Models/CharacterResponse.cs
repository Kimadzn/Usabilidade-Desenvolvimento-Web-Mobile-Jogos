
using System.Text.Json.Serialization;

namespace SearchDemonSlayerAPI.Models;

public class CharacterResponse
{
    [JsonPropertyName("content")]
    public List<Character> Content { get; set; } = new();

    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; } = new();
}

public class Pagination
{
    [JsonPropertyName("currentPage")]
    public int CurrentPage { get; set; }

    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }

    [JsonPropertyName("nextPage")]
    public string? NextPage { get; set; }

    [JsonPropertyName("previousPage")]
    public string? PreviousPage { get; set; }
}
