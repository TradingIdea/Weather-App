using MauiApp4.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp4.MVVM.ModelView
{
    [AddINotifyPropertyChangedInterface]
    public class WeatherViewModel
    {
        HttpClient httpClient;

        public WeatherData WeatherData { get; set; }

        public string PlaceName { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsVisible { get; set; }

        public bool IsLoding { get; set; }

        public WeatherViewModel()
        {
            httpClient = new HttpClient();
        }

        public ICommand SearchCommand => new Command(async (searchText) =>
        {
            IsLoding = true;

            PlaceName = searchText.ToString();

            var result = await GetCoordinate(searchText.ToString());
            await GetWeatherData(result);

            IsVisible = true;
            IsLoding = false;
        });

        public async Task<WeatherResult> GetCoordinate(string searchText)
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/search?name={searchText}";

            var response = await httpClient.GetAsync(url);

            WeatherResult weatherResult = null;

            if (response.IsSuccessStatusCode)
            {
                using(var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    //await = thread
                    weatherResult = await JsonSerializer.DeserializeAsync<WeatherResult>(responseStream);
                }
            }
            
            return weatherResult;
        }

        public async Task GetWeatherData(WeatherResult result)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={result.results[0].latitude}&longitude={result.results[0].longitude}&current=temperature_2m,weather_code,wind_speed_10m,wind_direction_10m&daily=weather_code,temperature_2m_max,temperature_2m_min&timezone=Asia%2FTokyo";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    
                    var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);

                    WeatherData = data;

                    for (int i = 0; i < WeatherData.daily.time.Length; i++)
                    {
                        var daily2 = new Daily2
                        {
                            time = WeatherData.daily.time[i],
                            temperature_2m_max = WeatherData.daily.temperature_2m_max[i],
                            temperature_2m_min = WeatherData.daily.temperature_2m_min[i],
                            weather_code = WeatherData.daily.weather_code[i]
                        };

                        WeatherData.daily2.Add(daily2);
                    }
                }
            }

        }
    }
}
