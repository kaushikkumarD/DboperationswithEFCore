using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
    }
}
