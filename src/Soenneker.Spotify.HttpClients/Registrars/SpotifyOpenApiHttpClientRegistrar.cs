using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Spotify.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Spotify.HttpClients.Registrars;

/// <summary>
/// Registers the authenticated Spotify Web API HTTP client provider.
/// </summary>
public static class SpotifyOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds the Spotify HTTP client provider as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddSpotifyOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ISpotifyOpenApiHttpClient, SpotifyOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds the Spotify HTTP client provider as a scoped service. Each scope owns a separate cached HTTP client. <para/>
    /// </summary>
    public static IServiceCollection AddSpotifyOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ISpotifyOpenApiHttpClient, SpotifyOpenApiHttpClient>();

        return services;
    }
}
