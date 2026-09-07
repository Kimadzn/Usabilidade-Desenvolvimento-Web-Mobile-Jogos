using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient cliente = new HttpClient())
        {
            string url = "https://api.adviceslip.com/advice";

            try
            {
                string resposta = await cliente.GetStringAsync(url);

                Conselho conselho = JsonSerializer.Deserialize<Conselho>(
                    resposta,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                Console.WriteLine("Conselho de Hoje:");
                Console.WriteLine(conselho.Slip.Advice);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro ao buscar o conselho.");
                Console.WriteLine(erro.Message);
            }
        }
    }
}

public class Conselho
{
    public Slip Slip { get; set; }
}

public class Slip
{
    public int Id { get; set; }
    public string Advice { get; set; }
}