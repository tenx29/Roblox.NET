using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Users.Models;

public class UserSearchResultsCollection
{
    [JsonProperty("previousPageCursor")] public string PreviousPageCursor { get; set; }

    [JsonProperty("nextPageCursor")] public string NextPageCursor { get; set; }

    [JsonProperty("data")] public IEnumerable<UserSearchResult> Data { get; set; }
}