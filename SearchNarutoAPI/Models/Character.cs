
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SearchNarutoAPI.Models;

public class Character
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("images")]
    public List<string> Images { get; set; } = [];

    [JsonPropertyName("personal")]
    public JsonElement Personal { get; set; }

    [JsonPropertyName("personalInfo")]
    public JsonElement PersonalInfo { get; set; }

    [JsonPropertyName("rank")]
    public JsonElement Rank { get; set; }

    [JsonPropertyName("jutsu")]
    public List<string> Jutsu { get; set; } = [];

    public string GetClanOrAffiliation()
    {
        var personal = Personal.ValueKind == JsonValueKind.Object
            ? Personal
            : PersonalInfo;

        var clan = GetValue(personal, "clan");

        if (!string.IsNullOrWhiteSpace(clan))
            return clan;

        var affiliation = GetValue(personal, "affiliation");

        return string.IsNullOrWhiteSpace(affiliation)
            ? "Não informado"
            : affiliation;
    }

    public string GetNinjaRank()
    {
        if (Rank.ValueKind != JsonValueKind.Object)
            return "Não informado";

        if (!Rank.TryGetProperty("ninjaRank", out var ninjaRank))
            return "Não informado";

        if (ninjaRank.ValueKind == JsonValueKind.String)
            return ninjaRank.GetString() ?? "Não informado";

        if (ninjaRank.ValueKind == JsonValueKind.Object)
        {
            var ranks = ninjaRank.EnumerateObject()
                .Select(x => x.Value.ToString())
                .Where(x => !string.IsNullOrWhiteSpace(x));

            return string.Join(", ", ranks);
        }

        return "Não informado";
    }

    private static string GetValue(JsonElement element, string property)
    {
        if (element.ValueKind != JsonValueKind.Object)
            return string.Empty;

        if (!element.TryGetProperty(property, out var value))
            return string.Empty;

        if (value.ValueKind == JsonValueKind.String)
            return value.GetString() ?? string.Empty;

        if (value.ValueKind == JsonValueKind.Array)
            return string.Join(", ",
                value.EnumerateArray().Select(x => x.ToString()));

        return value.ToString();
    }
}

public class CharacterResponse
{
    [JsonPropertyName("characters")]
    public List<Character> Characters { get; set; } = [];

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }

    [JsonPropertyName("page_size")]
    public int PageSizeSnake { get; set; }

    [JsonPropertyName("totalCharacters")]
    public int TotalCharacters { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("pageCount")]
    public int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public int Pages { get; set; }
}
