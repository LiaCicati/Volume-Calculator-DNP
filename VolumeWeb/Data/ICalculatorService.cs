using System.Collections.Generic;
using System.Threading.Tasks;
using VolumeWebService.VolumeCalculator;

namespace VolumeWeb.Data
{
    public interface ICalculatorService
    {
        Task<VolumeResult> CalculateCylinderVolumeAsync(double height, double radius);
        Task<VolumeResult> CalculateConeVolumeAsync(double radius, double height);
        Task<IList<VolumeResult>> GetAllResultAsync();
    }
}