using Lab27API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab27API.Services
{
    public class ApiWeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public ApiWeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Weather>> GetAll()
        {
            var response = await _client.GetFromJsonAsync<ApiWeatherGetAllResult>("points/39.7456,-97.0892");
            return response.Results;
        }

        public async Task<Rootobject> GetAllRoots()
        {
            var response = await _client.GetFromJsonAsync<ApiWeatherGetAllResult>("points/39.7456,-97.0892");
            return response.WeatherResults;
        }
    }

    public class ApiWeatherGetAllResult
    {
        public Rootobject WeatherResults { get; set; }
        public IEnumerable<Weather> Results { get; set; }
    }
}
