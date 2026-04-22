using Soenneker.Tests.HostedUnit;

namespace Soenneker.N8n.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class N8nOpenApiClientTests : HostedUnitTest
{
    public N8nOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
