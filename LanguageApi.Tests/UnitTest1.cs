using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Examination_CICD;

namespace LanguageApi.Tests;

public class CryptoTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public CryptoTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Encrypt_ShouldReturnShiftedText()
    {
        var response = await _client.PostAsync("/encrypt?text=hello", null);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<CryptoResponse>();
        Assert.Equal("ifmmp", content.result);
    }

    [Fact]
    public async Task Decrypt_ShouldReturnOriginalText()
    {
        var response = await _client.PostAsync("/decrypt?text=ifmmp", null);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<CryptoResponse>();
        Assert.Equal("hello", content.result);
    }
}

public class CryptoResponse
{
    public string original { get; set; }
    public string result { get; set; }
}