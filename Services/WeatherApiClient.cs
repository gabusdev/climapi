
using climapi.Models.Current;
namespace climapi.Services;

public class WeatherApiClient
{
    private readonly HttpClient client;
    public string? Uri { get; set; }
    private Dictionary<string, string> Parametros = new Dictionary<string, string>();

    public WeatherApiClient(string apiKey)
    {
        Uri uri = new Uri("http://api.weatherapi.com/v1/");
        client = new HttpClient(){
            BaseAddress = uri
        };
        Parametros.Add("key", apiKey);
    }

    public async Task<Current> getCurrentAsync(string q)
    {
        Uri = "current.json";
        Parametros.Add("q", q);
        string fullUri = Uri + ReadyParametros();
        var response = await client.GetAsync(fullUri);
        response.EnsureSuccessStatusCode();
        Current current = await response.Content.ReadAsAsync<Current>();
        return current;
    }

    private void addParametro(string key, string value)
    {
        if (!Parametros.ContainsKey(key))
            Parametros.Add(key, value);
        else
            Parametros[key] = value;
    }

    private string ReadyParametros()
    {
        string stringParametros = "?";
        foreach (var item in Parametros)
        {
            stringParametros += $"{item.Key}={item.Value}&";
        }
        return stringParametros;
    }
}

