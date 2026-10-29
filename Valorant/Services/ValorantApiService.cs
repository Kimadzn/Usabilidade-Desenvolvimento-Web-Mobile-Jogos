using System.Net.Http.Json;
using Valorant.Models;

namespace Valorant.Services;

public class ValorantApiService : IValorantApiService
{
    private readonly HttpClient _httpClient;

    public ValorantApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AgentData?> GetAgentByUuidAsync(string uuid)
    {
        if (string.IsNullOrWhiteSpace(uuid)) return null;
        try
        {
            var response = await _httpClient.GetFromJsonAsync<AgentResponse>($"https://valorant-api.com/v1/agents/{uuid.Trim()}");
            return response?.Data;
        }
        catch
        {
            return null;
        }
    }
}