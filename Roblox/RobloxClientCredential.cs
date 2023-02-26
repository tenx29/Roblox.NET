using System;

namespace Roblox
{
    /// <summary>
    ///     Stores the .ROBLOSECURITY cookie for the Roblox API.
    /// </summary>
    public class RobloxClientCredential
    {
        /// <summary>
        ///     Security cookie for the Roblox API.
        /// </summary>
        internal readonly string Cookie;

        /// <summary>
        ///     Create a new <see cref="RobloxClientCredential" /> instance.
        /// </summary>
        /// <param name="cookie">The full .ROBLOSECURITY cookie including the warning message</param>
        /// <exception cref="InvalidCookieException">Thrown if the given cookie has an invalid format</exception>
        public RobloxClientCredential(string cookie)
        {
            // When split using the sequence "|_", there should be 2 parts, of which the second part is the
            // security token with a length of 712 characters.

            var parts = cookie.Split(new[] {"|_"}, StringSplitOptions.None);

            if (parts.Length != 2 || parts[1].Length != 712)
                throw new InvalidCookieException("The cookie is invalid.");

            Cookie = cookie;
        }
    }

    /// <summary>
    ///     Exception thrown when the given cookie has an invalid format.
    /// </summary>
    public class InvalidCookieException : Exception
    {
        public InvalidCookieException(string message) : base(message) { }
    }
}