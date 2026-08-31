[![](https://img.shields.io/nuget/v/soenneker.n8n.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.n8n.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.n8n.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.n8n.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.n8n.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.n8n.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.n8n.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.n8n.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.N8n.OpenApiClient

Typed request builders and models for calling an n8n server's public API from .NET.

## Installation

```bash
dotnet add package Soenneker.N8n.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.N8n.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("X-N8N-API-KEY", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://n8n.example.com/api/v1"
};

var client = new N8nOpenApiClient(adapter);
var workflows = await client.Workflows.GetAsync(cancellationToken: cancellationToken);
```

Set `BaseUrl` to the public API endpoint for the n8n instance you are calling.

For application registration, configuration-based connections, and managed client reuse, use [`Soenneker.N8n.OpenApiClientUtil`](https://github.com/soenneker/soenneker.n8n.openapiclientutil).
