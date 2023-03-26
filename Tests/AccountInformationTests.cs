using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roblox.AccountInformation;
using Roblox.AccountInformation.Models;
using Tests.Helpers;

namespace tests;

[TestClass]
public class AccountInformationTests
{
    private static readonly Uri BaseUri = new("https://localhost");
    
    [TestMethod]
    public async Task GetBirthDateAsync()
    {
        var expected = new DateResponse()
        {
            Day = 1,
            Month = 1,
            Year = 2000,
        };
        var httpClient = MockHttpClientProvider.FromObjectResponse(expected);
        httpClient.BaseAddress = BaseUri;
        var client = new AccountInformationHttpClient(httpClient);
        var result = await client.GetBirthDateAsync();
        Assert.AreEqual(new DateTime(expected.Year, expected.Month, expected.Day), result);
    }
}