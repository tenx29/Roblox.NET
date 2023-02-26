using System;

namespace Roblox
{
    /// <summary>
    ///     Provides a base class for authenticated Roblox API clients used for APIs that require authentication.
    /// </summary>
    public class AuthenticatedRobloxHttpClientBase : RobloxHttpClientBase
    {
        protected RobloxClientCredential Credential;

        /// <summary>
        ///     Creates a new <see cref="AuthenticatedRobloxHttpClientBase" /> instance.
        /// </summary>
        /// <param name="baseUri">Base URI for the Roblox API</param>
        /// <param name="credential">Roblox authentication credential</param>
        public AuthenticatedRobloxHttpClientBase(Uri baseUri, RobloxClientCredential credential) : base(baseUri)
        {
            Credential = credential;
            HttpClient.DefaultRequestHeaders.Add("Cookie", Credential.Cookie);
        }
    }
}