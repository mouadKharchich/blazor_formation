using BookProjet.Data;
using static System.Net.WebRequestMethods;
using System;
using Microsoft.AspNetCore.Components;

namespace BookProjet.Pages
{
    public partial class WeeklyForecast
    {
        IEnumerable<WeatherForecast> forecasts;

        [Inject]
        HttpClient Http { get; set; }


        [Inject]
        WeatherForecastService WeatherServices { get; set; }
        protected override async Task OnInitializedAsync()
        {

            forecasts = await WeatherServices.GetForecastAsync(DateTime.Now);
            //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");

        }

        public void HandleItemSelected(DateTime date)
        {
            forecasts.Where(r => r.Date == date).FirstOrDefault().Selected = true;
        }
    }
}
