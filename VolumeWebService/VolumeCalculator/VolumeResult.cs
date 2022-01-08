using System.ComponentModel.DataAnnotations;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public double Volume { get; set; }
    }
}