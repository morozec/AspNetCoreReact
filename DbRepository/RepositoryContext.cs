using Microsoft.EntityFrameworkCore;
using Model;

namespace DbRepository
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}