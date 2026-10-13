
using System.Net.Http.Json;
using BlazorViaCep.Models;

namespace BlazorViaCep.Services;

public class ViaCepService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Endereco?> BuscarCep(string cep)
    {
        cep = new string(cep.Where(char.IsDigit).ToArray());

        if (cep.Length != 8)
            return null;

        var endereco = await _httpClient.GetFromJsonAsync<Endereco>(
            $"https://viacep.com.br/ws/{cep}/json/");

        if (endereco?.Cep == null)
            return null;

        return endereco;
    }
}
