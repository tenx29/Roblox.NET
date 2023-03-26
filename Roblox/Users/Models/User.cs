using System;
using Newtonsoft.Json;

namespace Roblox.Users.Models;

public class User
{
    [JsonProperty("description")] public string Description { get; set; }

    [JsonProperty("created")] public DateTime Created { get; set; }

    [JsonProperty("isBanned")] public bool IsBanned { get; set; }

    [JsonProperty("externalAppDisplayName")]
    public string ExternalAppDisplayName { get; set; }

    [JsonProperty("hasVerifiedBadge")] public bool HasVerifiedBadge { get; set; }

    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("displayName")] public string DisplayName { get; set; }
}