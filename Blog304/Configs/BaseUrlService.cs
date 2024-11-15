namespace Blog304.Configs;

public class BaseUrlService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public string BaseUrl => _httpClient.BaseAddress?.ToString() ?? string.Empty;
}
