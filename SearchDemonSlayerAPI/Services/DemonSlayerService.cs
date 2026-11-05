
using System.Net.Http.Json;
using SearchDemonSlayerAPI.Models;

namespace SearchDemonSlayerAPI.Services;

public class DemonSlayerService
{
    private readonly HttpClient _httpClient;

    public DemonSlayerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Character>> GetCharactersAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<CharacterResponse>(
            "api/v1/characters?page=1&limit=45"
        );

        return response?.Content ?? new List<Character>();
    }
}
