using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Digite o CEP: ");
        string cep = Console.ReadLine();

        string enderecoUrl = $"https://viacep.com.br/ws/{cep}/json/";

        using (HttpClient cliente = new HttpClient())
        {
            try
            {
                HttpResponseMessage resposta = await cliente.GetAsync(enderecoUrl);

                if (resposta.IsSuccessStatusCode)
                {
                    string json = await resposta.Content.ReadAsStringAsync();

                    Endereco endereco = JsonSerializer.Deserialize<Endereco>(json);

                    Console.WriteLine("\nEndereço encontrado:");
                    Console.WriteLine($"CEP: {endereco.Cep}");
                    Console.WriteLine($"Logradouro: {endereco.Logradouro}");
                    Console.WriteLine($"Complemento: {endereco.Complemento}");
                    Console.WriteLine($"Bairro: {endereco.Bairro}");
                    Console.WriteLine($"Cidade: {endereco.Localidade}");
                    Console.WriteLine($"Estado: {endereco.Uf}");
                    Console.WriteLine($"DDD: {endereco.Ddd}");
                }
                else
                {
                    Console.WriteLine("Erro ao consultar o CEP.");
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
        }
    }
}