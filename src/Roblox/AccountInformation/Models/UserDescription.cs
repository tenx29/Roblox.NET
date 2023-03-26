using System.Text.Json.Serialization;

namespace Roblox.AccountInformation.Models;

public class UserDescription
{
    [JsonPropertyName("description")]
    public string Description { get; init; }
}