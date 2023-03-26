using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Users.Models;

public class UserSearchResult
{
    [JsonProperty("previousUsernames")] public IEnumerable<string> PreviousUsernames { get; set; }

    [JsonProperty("hasVerifiedBadge")] public bool HasVerifiedBadge { get; set; }

    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("displayName")] public string DisplayName { get; set; }
}