using Microsoft.EntityFrameworkCore;

namespace Agilite_2.Context
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<PhoneInfo> PhoneInfos { get; set; }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options)
            : base(options)
        {
        }
    }
}
