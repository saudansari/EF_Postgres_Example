using Microsoft.EntityFrameworkCore;

namespace EF_Example
{
    public class StudentContext : DbContext
    {
        private const string _ConnectionString = "Host=localhost;Username=user;Password=password123;Database=user;Pooling=true;";

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_ConnectionString);
        }
    }
}
