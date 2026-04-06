using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.N8n.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class N8nOpenApiClientTests : FixturedUnitTest
{
    public N8nOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
