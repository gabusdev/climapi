
using climapi.Models;
using climapi.Models.MyCurrent;
namespace climapi.Services;

public class WeatherApiClient
{
    private readonly HttpClient client;
    public string? Uri { get; set; }
    private Dictionary<string, string> Parametros = new Dictionary<string, string>();

    public WeatherApiClient(string apiKey)
    {
        Uri uri = new Uri("http://api.weatherapi.com/v1/");
        client = new HttpClient()
        {
            BaseAddress = uri
        };
        Parametros.Add("key", apiKey);
    }

    public async Task<MyCurrent> getCurrentAsync(string q)
    {
        Uri = "current.json";
        Parametros.Add("q", q);
        string fullUri = Uri + ReadyParametros();
        var response = await client.GetAsync(fullUri);
        response.EnsureSuccessStatusCode();
        ExternalCurrent e_current = await response.Content.ReadAsAsync<ExternalCurrent>();
        MyCurrent m_current = convertCurrents(e_current);

        return m_current;
    }

    private MyCurrent convertCurrents(ExternalCurrent e)
    {
        MyCurrent m = new MyCurrent()
        {
            Location = e.Location,
            Temp_c = e.CurrentCurrent.TempC,
            Temp_f = e.CurrentCurrent.TempF,
            Wind = e.CurrentCurrent.WindKph,
            Wind_dir = Convert.ToChar(e.CurrentCurrent.WindDir),
            Condition = e.CurrentCurrent.Condition.Text
        };
        return m;
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

