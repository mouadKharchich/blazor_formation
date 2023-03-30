using static System.Net.WebRequestMethods;


namespace BookProjet.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
 {
            //"Freezing", "Bracing", "Chilly", "Cool", "Mild",
            //"Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            "Cloudy", "Rainy", "Sunny"
 };
        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var forecasts = new List<WeatherForecast>();



            for (var i = 0; i < 5; i++)
            {
                var forecastDate = startDate.AddDays(i);
                var temperatureC = rng.Next(-20, 55);
                var summary = Summaries[rng.Next(Summaries.Length)];



                var forecast = new WeatherForecast
                {
                    Date = forecastDate,
                    TemperatureC = temperatureC,
                    Summary = summary
                };



                forecasts.Add(forecast);
            }



            await Task.CompletedTask;
            return forecasts;
        }
    }




}
