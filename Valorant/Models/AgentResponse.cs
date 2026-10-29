namespace Valorant.Models;

public class AgentResponse
{
    public int Status { get; set; }
    public AgentData? Data { get; set; }
}

public class AgentData
{
    public string Uuid { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? FullPortrait { get; set; }
}