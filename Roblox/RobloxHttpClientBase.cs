using System;
using System.Net.Http;

namespace Roblox
{
    /// <summary>
    ///     Provides a base class for Roblox API clients.
    /// </summary>
    public class RobloxHttpClientBase
    {
        public readonly Uri BaseUri;

        /// <summary>
        ///     Creates a new <see cref="RobloxHttpClientBase" /> instance.
        /// </summary>
        /// <param name="baseUri">Base URI for the Roblox API</param>
        public RobloxHttpClientBase(Uri baseUri)
        {
            BaseUri = baseUri;
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = BaseUri;
        }

        protected HttpClient HttpClient { get; }
    }
}