using Soenneker.Spotify.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Spotify.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SpotifyOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ISpotifyOpenApiHttpClient _httpclient;

    public SpotifyOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ISpotifyOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
