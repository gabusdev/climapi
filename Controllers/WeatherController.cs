
using climapi.Services;
using climapi.Models.Current;
using Microsoft.AspNetCore.Mvc;

namespace climapi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly WeatherApiClient _weatherApiClient;

    public WeatherController()
    {
        string apiKey = "yourWeatherApiKey";
        _weatherApiClient = new WeatherApiClient(apiKey);
    }

    [HttpGet]
    public async Task<ActionResult<Current>> GetCurrent(){
        try
        {
            return await _weatherApiClient.getCurrentAsync("Havana");
        }
        catch (Exception)
        {
            
            return NotFound();
        }
    }

}