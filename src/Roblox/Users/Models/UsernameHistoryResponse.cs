using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Users.Models;

public class UsernameHistoryResponse
{
    [JsonProperty("previousPageCursor")] public string PreviousPageCursor { get; set; }

    [JsonProperty("nextPageCursor")] public string NextPageCursor { get; set; }

    [JsonProperty("data")] public IEnumerable<string> Data { get; set; }
}