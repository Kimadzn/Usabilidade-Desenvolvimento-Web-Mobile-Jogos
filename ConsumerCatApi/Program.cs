using System.Net.Http;
using System.Text.Json;

Console.WriteLine("Fato sobre Gatos:");

using HttpClient client = new HttpClient();

string url = "https://catfact.ninja/fact";

string resposta = await client.GetStringAsync(url);

JsonDocument json = JsonDocument.Parse(resposta);

string fato = json.RootElement.GetProperty("fact").GetString();

Console.WriteLine(fato);