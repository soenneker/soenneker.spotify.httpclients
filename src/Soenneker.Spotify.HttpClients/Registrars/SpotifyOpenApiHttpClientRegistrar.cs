using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Spotify.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Spotify.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class SpotifyOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="SpotifyOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddSpotifyOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ISpotifyOpenApiHttpClient, SpotifyOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="SpotifyOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddSpotifyOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ISpotifyOpenApiHttpClient, SpotifyOpenApiHttpClient>();

        return services;
    }
}
