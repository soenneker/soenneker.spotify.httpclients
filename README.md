[![](https://img.shields.io/nuget/v/soenneker.spotify.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.spotify.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.spotify.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.spotify.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.spotify.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.spotify.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.spotify.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.spotify.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Spotify.HttpClients

Provides a reusable `HttpClient` configured for the Spotify Web API with bearer-token authentication.

## Installation

```bash
dotnet add package Soenneker.Spotify.HttpClients
```

## Configuration

```json
{
  "Spotify": {
    "ApiKey": "your-spotify-access-token"
  }
}
```

The access token must include the scopes required by the endpoints you call. `Spotify:ClientBaseUrl`, `Spotify:AuthHeaderName`, and `Spotify:AuthHeaderValueTemplate` can override the defaults.

## Usage

```csharp
using Soenneker.Spotify.HttpClients.Abstract;
using Soenneker.Spotify.HttpClients.Registrars;

services.AddSpotifyOpenApiHttpClientAsSingleton();

HttpClient client = await spotifyHttpClient.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync("me", cancellationToken);
```

The provider owns the cached `HttpClient`; disposing the provider removes and disposes that client. Scoped registration creates an independently owned client for each scope.
