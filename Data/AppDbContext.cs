using Health_And_Fitness_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Health_And_Fitness_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Calorie> calories { get; set; }
    }
}
