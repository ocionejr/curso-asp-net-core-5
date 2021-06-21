using Microsoft.EntityFrameworkCore;

namespace RestWithASPNETUdemy.Model.Context
{
    public class PostgresqlContext : DbContext
    {
        public PostgresqlContext() { }

        public PostgresqlContext(DbContextOptions<PostgresqlContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
