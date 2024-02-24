using Microsoft.EntityFrameworkCore;

namespace TestingGitHub_Podium.Data
{
    public class TestDbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Genre> Genres { get; set; }

        public DbSet<Models.Movie> Movies { get; set; }


    }
}