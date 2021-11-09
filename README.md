# Signicat Express .NET SDK
[![Tests](https://github.com/signicat/signicat-express-net/actions/workflows/test.yml/badge.svg)](https://github.com/signicat/signicat-express-net/actions/workflows/test.yml)
 [![NuGet](https://img.shields.io/nuget/v/Signicat.Express.SDK.svg)](https://www.nuget.org/packages/Signicat.Express.SDK)

A .NET SDK for simple integration with the Signicat Express REST API.

Supports .NET Standard 2.0+, .NET Core 2.0+ and .NET Framework 4.6.1+.

## Installation
Using NuGet is the easiest way to install the SDK.

Package Manager:

	PM > Install-Package Signicat.Express.SDK

.NET Core CLI:  

	dotnet add package Signicat.Express.SDK

## Documentation
- [Signicat Express REST API Reference](https://developer.signicat.com/express/apis/overview.html)
- [Signicat Express Developer Documentation](https://developer.signicat.com/express/docs)


## Sample Usage
The example below shows how to get the details of a specific document.

```csharp
// Set your credentials and desired scopes
SignicatConfiguration.SetClientCredentials("clientId", "clientSecret",
    new[] {OAuthScope.DocumentRead, OAuthScope.DocumentWrite});

// Make a call to retrieve the document
var signatureService = new SignatureService();
var document = signatureService.GetDocument(documentId);

Console.WriteLine($"Retrieved document: {document.Title}");
```

## Support
- Open an [issue](https://github.com/signicat/signicat-express-net/issues) to report bugs or submit feature requests.
- For other support requests, visit [Signicat Community](https://community.signicat.com).
