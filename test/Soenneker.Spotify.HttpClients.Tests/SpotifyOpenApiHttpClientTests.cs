using Soenneker.Spotify.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Spotify.HttpClients.Tests;

[Collection("Collection")]
public sealed class SpotifyOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ISpotifyOpenApiHttpClient _httpclient;

    public SpotifyOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ISpotifyOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
