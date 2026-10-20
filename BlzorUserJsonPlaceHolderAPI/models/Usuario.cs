
namespace BlzorUserJsonPlaceHolderAPI.Models;

public class Usuario
{
    public string Name { get; set; } = string.Empty;
    public Endereco Address { get; set; } = new();
    public Empresa Company { get; set; } = new();
}

public class Endereco
{
    public string City { get; set; } = string.Empty;
}

public class Empresa
{
    public string Name { get; set; } = string.Empty;
}
