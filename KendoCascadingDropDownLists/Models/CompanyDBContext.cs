using Microsoft.EntityFrameworkCore;

namespace KendoCascadingDropDownLists.Models
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions options) : base (options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
