using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Spotify.HttpClients.Abstract;

/// <summary>
/// Provides an authenticated HTTP client for the Spotify Web API.
/// </summary>
public interface ISpotifyOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the shared HTTP client owned by this provider instance.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);

    /// <summary>Removes and disposes the HTTP client owned by this provider.</summary>
    new void Dispose();

    /// <summary>Asynchronously removes and disposes the HTTP client owned by this provider.</summary>
    new ValueTask DisposeAsync();
}
