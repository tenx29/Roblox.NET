using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models;

public class PromotionChannels
{
    [JsonProperty("facebook")] public string Facebook { get; set; }

    [JsonProperty("twitter")] public string Twitter { get; set; }

    [JsonProperty("youtube")] public string Youtube { get; set; }

    [JsonProperty("twitch")] public string Twitch { get; set; }

    [JsonProperty("guilded")] public string Guilded { get; set; }
}