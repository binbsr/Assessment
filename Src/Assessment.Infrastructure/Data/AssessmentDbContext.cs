using Microsoft.EntityFrameworkCore;

namespace Assessment.Infrastructure.Data
{
    public class AssessmentDbContext : DbContext
    {
        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options)
            : base(options)
        {
        }
    }
}