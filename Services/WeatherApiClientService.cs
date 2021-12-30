
// using climapi.Models.Current;
using climapi.Models.MyCurrent;
using climapi.Models.MyForecast;
// using climapi.Models.Forecast;
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
        Models.Current.ExternalCurrent e_current = await response.Content.ReadAsAsync<Models.Current.ExternalCurrent>();
        MyCurrent m_current = convertCurrents(e_current);

        return m_current;
    }

    public async Task<MyForecast> getForecastAsync(string q, string days)
    {
        Uri = "forecast.json";
        Parametros.Add("q", q);
        Parametros.Add("days", days);
        string fullUri = Uri + ReadyParametros();
        var response = await client.GetAsync(fullUri);
        response.EnsureSuccessStatusCode();
        Models.Forecast.ExternalForecast e_forecast = await response.Content.ReadAsAsync<Models.Forecast.ExternalForecast>();
        MyForecast m_forecast = convertForecasts(e_forecast);

        return m_forecast;
    }

    private MyForecast convertForecasts(Models.Forecast.ExternalForecast e)
    {

        MyForecast m_forecast = new MyForecast()
        {
            FLocation = e.Location,
            Temp_c = e.Current.TempC,
            Temp_f = e.Current.TempF,
            Wind = e.Current.WindKph,
            Wind_dir = Convert.ToChar(e.Current.WindDir),
            Condition = e.Current.Condition.Text.ToString(),
            Date = e.Location.Localtime.Substring(0, 10)
        };
        foreach (var x in e.ForecastForecast.Forecastday)
        {
            m_forecast.Siguientes.Add(new MyCurrent()
            {
                Temp_c = x.Day.AvgtempC,
                Temp_f = x.Day.AvgtempF,
                Wind = x.Day.MaxwindKph,
                Condition = x.Day.Condition.Text.ToString(),
                Date = x.Date.ToString()
            });
        }

        return m_forecast;
    }

    private MyCurrent convertCurrents(Models.Current.ExternalCurrent e)
    {
        MyCurrent m = new MyCurrent()
        {
            Location = e.Location,
            Temp_c = e.CurrentCurrent.TempC,
            Temp_f = e.CurrentCurrent.TempF,
            Wind = e.CurrentCurrent.WindKph,
            Wind_dir = Convert.ToChar(e.CurrentCurrent.WindDir),
            Condition = e.CurrentCurrent.Condition.Text,
            Date = e.Location.Localtime.Substring(0, 10)
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

