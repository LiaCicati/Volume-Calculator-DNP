using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using VolumeWebService.VolumeCalculator;

namespace VolumeWeb.Data.Impl
{
    public class CalculatorService : ICalculatorService
    {
        private string uri = "https://localhost:5003";
        private HttpClient _client;

        public CalculatorService()
        {
            this._client = new HttpClient();
        }

        public async Task<VolumeResult> CalculateCylinderVolumeAsync(double height, double radius)
        {
            var response = await _client.GetAsync(uri + $"/calculate/cylinder/height={height}&radius={radius}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<VolumeResult>(json);
        }

        public async Task<VolumeResult> CalculateConeVolumeAsync(double radius, double height)
        {
            var response = await _client.GetAsync(uri + $"/calculate/cone/radius={radius}&height={height}");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<VolumeResult>(json);
        }

        public async Task<IList<VolumeResult>> GetAllResultAsync()
        {
            var response = await _client.GetAsync(uri + "/calculate/results/");
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<VolumeResult>>(json);
        }
    }
}