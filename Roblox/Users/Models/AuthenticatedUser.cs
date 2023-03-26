using Newtonsoft.Json;

namespace Roblox.Users.Models;

public class AuthenticatedUser
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("displayName")] public string DisplayName { get; set; }
}