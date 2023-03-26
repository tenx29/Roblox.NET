﻿using System;
using System.Net.Http;

namespace Roblox;

/// <summary>
///     Provides functionality for Roblox API clients.
/// </summary>
public interface IRobloxHttpClient
{
    /// <summary>
    ///     Base URI for the API.
    /// </summary>
    public Uri BaseUri { get; }

    /// <summary>
    ///     The authentication status of the client.
    /// </summary>
    bool IsAuthenticated { get; }
}