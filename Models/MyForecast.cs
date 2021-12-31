namespace climapi.Models.MyForecast
{
    public class MyForecast : MyCurrent.MyCurrent
    {
        // public Forecast.Location? FLocation { get; set; }
        public List<MyCurrent.MyCurrent>? Pronostico { get; set; } 
    }
}