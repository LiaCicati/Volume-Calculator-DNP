using System.Collections.Generic;
using System.Linq;
using VolumeWebService.DataAccess;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Data.Impl
{
    public class VolumeResultRepository : IVolumeResultRepository
    {
        private CalculatorDbContext _ctx;

        public VolumeResultRepository(CalculatorDbContext context)
        {
            this._ctx = context;
        }

        public VolumeResult AddResult(VolumeResult volumeResult)
        {
            _ctx.VolumeResults.Add(volumeResult);
            _ctx.SaveChanges();
            return volumeResult;
        }

        public List<VolumeResult> GetAllResults()
        {
            return _ctx.VolumeResults.ToList();
        }
    }
}