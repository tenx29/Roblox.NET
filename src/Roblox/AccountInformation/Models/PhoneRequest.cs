using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models;

public class PhoneRequest : Phone
{
    [JsonProperty("password")] public string Password { get; set; }
}