using Microsoft.EntityFrameworkCore;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.DataAccess
{
    public class CalculatorDbContext : DbContext
    {
        public DbSet<VolumeResult> VolumeResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\Users\Lia Cicati\EXAMS-3-Semester\DNP\Exams\DNP1exam-304134\VolumeWebService\CalculatorDB.db");
        }
    }
}