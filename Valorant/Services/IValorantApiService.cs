using Valorant.Models;

namespace Valorant.Services;

public interface IValorantApiService
{
    Task<AgentData?> GetAgentByUuidAsync(string uuid);
}