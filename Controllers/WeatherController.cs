
using climapi.Services;
using climapi.Models.MyCurrent;
using climapi.Models.MyForecast;
using Microsoft.AspNetCore.Mvc;

namespace climapi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly WeatherApiClient _weatherApiClient;

    public WeatherController()
    {
        string apiKey = "e4ee022633474f34acd163310212812";
        _weatherApiClient = new WeatherApiClient(apiKey);
    }

    [HttpGet("{q}/current")]
    public async Task<ActionResult<MyCurrent>> GetCurrent(string q){
        try
        {
            return await _weatherApiClient.getCurrentAsync(q);
        }
        catch (Exception)
        {
            
            return NotFound();
        }
    }

    [HttpGet("{q}/forecast/{d}")]
    public async Task<ActionResult<MyForecast>> GetForecast(string q, string d){
        try
        {
            return await _weatherApiClient.getForecastAsync(q, d);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return NotFound();
        }
    }

}