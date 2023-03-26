using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Users.Models;

namespace Roblox.Users;

public interface IUsersHttpClient
{
    /// <summary>
    ///     Validate a display name for a new user. Throws an exception if the display name is invalid.
    /// </summary>
    /// <param name="displayName"></param>
    /// <param name="birthDate">Birth date of the new user</param>
    /// <exception cref="DisplayNameInvalidException">Thrown if the display name is invalid</exception>
    /// <returns></returns>
    Task Async(string displayName, DateTime birthDate);

    /// <summary>
    ///     Validate a display name for an existing user. Throws an exception if the display name is invalid.
    /// </summary>
    /// <param name="displayName"></param>
    /// <param name="userId"></param>
    /// <exception cref="DisplayNameInvalidException">Thrown if the display name is invalid</exception>
    /// <returns></returns>
    Task ValidateDisplayNameAsync(string displayName, long userId);

    /// <summary>
    ///     Set the display name of the authenticated user.
    /// </summary>
    /// <param name="displayName"></param>
    /// <param name="userId"></param>
    /// <exception cref="DisplayNameInvalidException">Thrown if the display name is invalid</exception>
    /// <returns></returns>
    Task SetDisplayNameAsync(string displayName, long userId);

    /// <summary>
    ///     Get detailed user information by userId.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>User information</returns>
    Task<User> GetUserAsync(long userId);

    /// <summary>
    ///     Get minimal user information of the authenticated user.
    /// </summary>
    /// <returns></returns>
    Task<AuthenticatedUser> GetAuthenticatedUserAsync();

    /// <summary>
    ///     Get the age bracket of the authenticated user.
    /// </summary>
    /// <returns></returns>
    Task<int> GetAuthenticatedUserAgeBracketAsync();

    /// <summary>
    ///     Get the country code of the authenticated user.
    /// </summary>
    /// <returns></returns>
    Task<string> GetAuthenticatedUserCountryCodeAsync();

    /// <summary>
    ///     Get the roles of the authenticated user.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<string>> GetAuthenticatedUserRolesAsync();

    /// <summary>
    ///     Get users by usernames. The results will also include old usernames of the users.
    /// </summary>
    /// <param name="usernames"></param>
    /// <param name="excludeBannedUsers"></param>
    /// <returns></returns>
    Task<IEnumerable<UserSearchResult>> GetUsersByUsernamesAsync(IEnumerable<string> usernames,
        bool excludeBannedUsers = true);

    /// <summary>
    ///     Get users by userIds.
    /// </summary>
    /// <param name="userIds"></param>
    /// <param name="excludeBannedUsers"></param>
    /// <returns></returns>
    Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<long> userIds, bool excludeBannedUsers = true);

    /// <summary>
    ///     Get the username history of a user. The result will only have partial history, with a cursor property to get the
    ///     next page.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="limit">Maximum number of results per request. Can be 10, 25, 50 or 100.</param>
    /// <param name="cursor">Paging cursor for the previous or next page</param>
    /// <param name="sortOrder">Sorting order for the results</param>
    /// <returns></returns>
    Task<UsernameHistoryResponse> GetUsernameHistoryAsync(long userId, int limit = 10, string cursor = null,
        ResultSortOrder sortOrder = ResultSortOrder.Ascending);

    /// <summary>
    ///     Search for users by keyword. The result will only have partial results, with a cursor property to get the next
    ///     page.
    /// </summary>
    /// <param name="keyword"></param>
    /// <param name="limit">Maximum number of results per request. Can be 10, 25, 50 or 100.</param>
    /// <param name="cursor">Paging cursor for the previous or next page</param>
    /// <returns></returns>
    Task<UserSearchResultsCollection> SearchUsersAsync(string keyword, int limit = 10, string cursor = null);
}