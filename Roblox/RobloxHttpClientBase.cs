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
        protected readonly HttpClient HttpClient;
        protected RobloxClientCredential Credential;

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

        /// <summary>
        ///     Creates a new <see cref="RobloxHttpClientBase" /> instance with user credentials.
        /// </summary>
        /// <param name="baseUri"></param>
        /// <param name="credential"></param>
        public RobloxHttpClientBase(Uri baseUri, RobloxClientCredential credential) : this(baseUri)
        {
            Credential = credential;
            HttpClient.DefaultRequestHeaders.Add("Cookie", $".ROBLOSECURITY={Credential.Cookie}");
        }

        /// <summary>
        ///     The authentication status of the client.
        /// </summary>
        public bool IsAuthenticated => Credential != null;

        /// <summary>
        ///     Authenticates the client with the given credentials after the client has been created.
        /// </summary>
        /// <param name="credential"></param>
        public void Authenticate(RobloxClientCredential credential)
        {
            Credential = credential;
            HttpClient.DefaultRequestHeaders.Add("Cookie", $".ROBLOSECURITY={Credential.Cookie}");
        }

        /// <summary>
        ///     Removes the authentication token from the client.
        /// </summary>
        public void RemoveAuthentication()
        {
            Credential = null;
            HttpClient.DefaultRequestHeaders.Remove("Cookie");
        }
    }
}