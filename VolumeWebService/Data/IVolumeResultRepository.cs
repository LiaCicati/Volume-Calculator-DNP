using System.Collections.Generic;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Data
{
    public interface IVolumeResultRepository
    {
        public VolumeResult AddResult(VolumeResult volumeResult);
        public List<VolumeResult> GetAllResults();
    }
}