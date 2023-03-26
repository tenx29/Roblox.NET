using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;

namespace Tests.Helpers;

public static class MockHttpClientProvider
{
    /// <summary>
    ///     Create a new mock HttpClient from a HttpResponseMessage
    /// </summary>
    /// <param name="result">Result which the client should return when first called</param>
    /// <returns></returns>
    public static HttpClient FromResponse(HttpResponseMessage result)
    {
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = result;
        
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(response)
            .Verifiable();
        
        return new HttpClient(handlerMock.Object);
    }
    
    /// <summary>
    ///     Create a new mock HttpClient from a sequence of HttpResponseMessages
    /// </summary>
    /// <param name="results">Results which are returned in the same order</param>
    /// <returns></returns>
    public static HttpClient FromResponseSequence(IEnumerable<HttpResponseMessage> results)
    {
        var handlerMock = new Mock<HttpMessageHandler>();
        var responseSequence = results;

        handlerMock.Protected()
            .SetupSequence<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(responseSequence.GetEnumerator().Current);
        
        return new HttpClient(handlerMock.Object);
    }

    /// <summary>
    ///     Create a new mock HttpClient from a JSON string and a status code
    /// </summary>
    /// <param name="json"></param>
    /// <param name="statusCode"></param>
    /// <returns></returns>
    public static HttpClient FromJsonResponse(string json, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(json),
        };
        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(response)
            .Verifiable();
        
        return new HttpClient(handlerMock.Object);
    }
    
    /// <summary>
    ///     Create a new mock HttpClient from an object and a status code.
    ///     The object will be serialized to JSON.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="statusCode"></param>
    /// <returns></returns>
    public static HttpClient FromObjectResponse(object obj, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(JsonSerializer.Serialize(obj)),
        };
        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(response)
            .Verifiable();
        
        return new HttpClient(handlerMock.Object);
    }
    
    public static HttpClient FromEmptyResponse(HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage(statusCode);
        
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(response)
            .Verifiable();
        
        return new HttpClient(handlerMock.Object);
    }
}