using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models
{
    public class StarCodeAffiliate
    {
        [JsonProperty("userId")] public long UserId { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("code")] public string Code { get; set; }
    }
}