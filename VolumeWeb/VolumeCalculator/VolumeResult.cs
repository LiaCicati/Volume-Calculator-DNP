using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("height")] public double Height { get; set; }
        [JsonPropertyName("radius")] public double Radius { get; set; }
        [JsonPropertyName("volume")] public double Volume { get; set; }
    }
}