
using climapi.Services;
using climapi.Models.MyCurrent;
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

    [HttpGet("{q}")]
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

}