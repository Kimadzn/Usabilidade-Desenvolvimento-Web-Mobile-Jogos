
using System.Net.Http.Json;
using SearchNarutoAPI.Models;

namespace SearchNarutoAPI.Services;

public class NarutoService
{
    private readonly HttpClient _http;

    public NarutoService(HttpClient http)
    {
        _http = http;
    }

    public async Task<CharacterResponse> GetCharactersAsync(
        int page = 1,
        int limit = 20,
        string name = "")
    {
        var url = $"characters?page={page}&limit={limit}";

        if (!string.IsNullOrWhiteSpace(name))
        {
            url += $"&name={Uri.EscapeDataString(name)}";
        }

        var response = await _http.GetFromJsonAsync<CharacterResponse>(url);

        return response ?? new CharacterResponse();
    }

    public async Task<Character?> GetCharacterByIdAsync(int id)
    {
        return await _http.GetFromJsonAsync<Character>(
            $"characters/{id}");
    }
}
