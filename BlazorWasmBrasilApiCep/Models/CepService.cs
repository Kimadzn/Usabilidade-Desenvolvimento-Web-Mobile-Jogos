using System.Net.Http.Json;

public class CepService
{
    private readonly HttpClient _httpClient;

    public CepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CepResponse?> ObterCepAsync(string cep)
    {
        var cepLimpo = new string(cep.Where(char.IsDigit).ToArray());
        if (cepLimpo.Length != 8) return null;

        try
        {
            return await _httpClient.GetFromJsonAsync<CepResponse>($"api/cep/v2/{cepLimpo}");
        }
        catch
        {
            return null;
        }
    }
}