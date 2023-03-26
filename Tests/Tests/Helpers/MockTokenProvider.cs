using Roblox;

namespace Tests.Helpers;

/// <summary>
///     Provides a mock token provider for testing.
/// </summary>
public class MockTokenProvider
{
    /// <summary>
    ///     Mock .ROBLOSECURITY cookie.
    /// </summary>
    public static string Cookie = $"|_{new string('0', 712)}";

    /// <summary>
    ///     Mock RobloxClientCredential.
    /// </summary>
    public static RobloxClientCredential Credential = new(Cookie);
}