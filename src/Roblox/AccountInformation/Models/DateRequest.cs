using System.Text.Json.Serialization;

namespace Roblox.AccountInformation.Models;

/// <summary>
///     Models a date.
/// </summary>
public class DateRequest
{
    /// <summary>
    ///     The day of the month.
    /// </summary>
    [JsonPropertyName("birthDay")]
    public int Day { get; init; }

    /// <summary>
    ///     The month of the year.
    /// </summary>
    [JsonPropertyName("birthMonth")]
    public int Month { get; init; }

    /// <summary>
    ///     The year.
    /// </summary>
    [JsonPropertyName("birthYear")]
    public int Year { get; init; }
    
    /// <summary>
    ///     Optional password.
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; init; }
}