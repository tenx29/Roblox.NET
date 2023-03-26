using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Roblox.AccountInformation.Models;

namespace Roblox.AccountInformation;

public class AccountInformationHttpClient : RobloxHttpClientBase
{
    public new static Uri BaseUri { get; } = new("https://accountinformation.roblox.com");
    
    /// <summary>
    ///     Create a new <see cref="AccountInformationHttpClient" />.
    /// </summary>
    public AccountInformationHttpClient() : base(BaseUri) { }
    
    /// <summary>
    ///     Create a new <see cref="AccountInformationHttpClient" /> with user credentials.
    /// </summary>
    /// <param name="credential"></param>
    public AccountInformationHttpClient(RobloxClientCredential credential) : base(BaseUri, credential) { }
    
    /// <summary>
    ///     Create a new <see cref="AccountInformationHttpClient" /> with a custom <see cref="HttpClient" />.
    /// </summary>
    /// <param name="httpClient"></param>
    public AccountInformationHttpClient(HttpClient httpClient) : base(httpClient) { }
    
    #region AccountInformation API

    /// <summary>
    ///     Get the authenticated user's birth date.
    /// </summary>
    /// <returns></returns>
    public async Task<DateTime> GetBirthDateAsync()
    {
        var response = await HttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/v1/birthdate"));
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<DateResponse>();
        return new DateTime(result.Year, result.Month, result.Day);
    }
    /*
    /// <summary>
    ///     Update the authenticated user's birth date.
    /// </summary>
    /// <param name="date">The new birth date. Only year, month and day will be used.</param>
    /// <param name="password"></param>
    /// <returns></returns>
    Task SetBirthDateAsync(DateTime date, string password = null);

    /// <summary>
    ///     Get the authenticated user's description.
    /// </summary>
    /// <returns>Description of the user</returns>
    Task<string> GetDescriptionAsync();

    /// <summary>
    ///     Set the authenticated user's description.
    /// </summary>
    /// <param name="description"></param>
    /// <returns>New description of the user</returns>
    Task<string> SetDescriptionAsync(string description);

    /// <summary>
    ///     Get the authenticated user's gender.
    /// </summary>
    /// <returns></returns>
    Task<Gender> GetGenderAsync();

    /// <summary>
    ///     Set the authenticated user's gender.
    /// </summary>
    /// <param name="gender">New gender of the user</param>
    /// <returns></returns>
    Task SetGenderAsync(Gender gender);

    /// <summary>
    ///     Get the amount of consecutive days the authenticated user has logged into Xbox Live.
    ///     Returns -1 if the user is not connected to an Xbox Live account.
    /// </summary>
    /// <returns></returns>
    Task<int> GetXboxLiveConsecutiveLoginDaysAsync();

    /// <summary>
    ///     Get the metadata for the authenticated user's account.
    /// </summary>
    /// <returns></returns>
    Task<AccountInformationMetadata> GetMetadataAsync();

    /// <summary>
    ///     Get the authenticated user's verified phone number.
    /// </summary>
    /// <returns></returns>
    Task<PhoneResponse> GetPhoneAsync();

    /// <summary>
    ///     Set the authenticated user's phone number.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task SetPhoneAsync(PhoneRequest request);

    /// <summary>
    ///     Delete the given phone number.
    /// </summary>
    /// <returns></returns>
    Task DeletePhoneAsync();

    /// <summary>
    ///     Resend the verification code for the authenticated user's phone number.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task ResendPhoneVerificationAsync(PhoneRequest request);

    /// <summary>
    ///     Verify the authenticated user's phone number.
    /// </summary>
    /// <param name="verificationCode"></param>
    /// <returns></returns>
    Task VerifyPhoneAsync(string verificationCode);

    /// <summary>
    ///     Get the authenticated user's promotion channels.
    /// </summary>
    /// <returns></returns>
    Task<AuthenticatedPromotionChannels> GetPromotionChannelsAsync();

    /// <summary>
    ///     Get the promotion channels for the given user.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<PromotionChannels> GetPromotionChannelsAsync(long userId);

    /// <summary>
    ///     Update the authenticated user's promotion channels.
    /// </summary>
    /// <param name="channels"></param>
    /// <returns></returns>
    Task SetPromotionChannelsAsync(AuthenticatedPromotionChannels channels);

    /// <summary>
    ///     Remove the authenticated user's star code affiliate supporter.
    /// </summary>
    /// <returns></returns>
    Task DeleteStarCodeAffiliateAsync();

    /// <summary>
    ///     Get the authenticated user's star code affiliate supporter.
    /// </summary>
    /// <returns></returns>
    Task<StarCodeAffiliate> GetStarCodeAffiliateAsync();

    /// <summary>
    ///     Adds a star code affiliate supporter to the authenticated user.
    /// </summary>
    /// <param name="code">Star code affiliate code</param>
    /// <returns></returns>
    Task<StarCodeAffiliate> AddStarCodeAffiliateAsync(string code);

    /// <summary>
    ///     Returns a collection of badges belonging to the given user.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Collection of badges</returns>
    Task<IEnumerable<Badge>> GetBadgesAsync(long userId);

    /// <summary>
    ///     Verify the authenticated user's email from a verification ticket.
    /// </summary>
    /// <param name="verificationTicket"></param>
    /// <returns>Asset ID of the verified user hat</returns>
    Task<long> VerifyEmailAsync(string verificationTicket);
    */
    #endregion
}