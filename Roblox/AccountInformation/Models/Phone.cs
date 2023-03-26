using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models;

public class Phone
{
    [JsonProperty("countryCode")] public string CountryCode { get; set; }

    [JsonProperty("prefix")] public string Prefix { get; set; }

    [JsonProperty("phone")] public string PhoneNumber { get; set; }
}