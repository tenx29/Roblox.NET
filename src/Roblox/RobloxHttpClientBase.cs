using System;
using System.Net.Http;

namespace Roblox;

/// <summary>
///     Provides a base class for Roblox API clients.
/// </summary>
public class RobloxHttpClientBase : IRobloxHttpClient
{
    public Uri BaseUri { get; }
    
    /// <summary>
    ///     HTTP client used for requests.
    /// </summary>
    protected HttpClient HttpClient { get; set; }
    
    /// <summary>
    ///     Credentials used for authentication.
    /// </summary>
    protected RobloxClientCredential Credential { private get; set; }

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
    ///     Creates a new <see cref="RobloxHttpClientBase" /> instance with a custom <see cref="HttpClient" />.
    /// </summary>
    /// <param name="baseUri"></param>
    /// <param name="httpClient"></param>
    public RobloxHttpClientBase(Uri baseUri, HttpClient httpClient)
    {
        BaseUri = baseUri;
        HttpClient = httpClient;
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