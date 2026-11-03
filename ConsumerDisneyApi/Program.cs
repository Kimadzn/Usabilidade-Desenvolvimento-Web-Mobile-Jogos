using System.Net.Http;
using System.Text.Json;

Console.WriteLine("Dados do Personagem:");

using HttpClient client = new HttpClient();

string url = "https://api.disneyapi.dev/character/423";

string resposta = await client.GetStringAsync(url);

JsonDocument json = JsonDocument.Parse(resposta);

JsonElement dados = json.RootElement.GetProperty("data");

string nome = dados.GetProperty("name").GetString() ?? "";
string imagem = dados.GetProperty("imageUrl").GetString() ?? "";

Console.WriteLine("Nome:");
Console.WriteLine(nome);

Console.WriteLine("Imagem:");
Console.WriteLine(imagem);