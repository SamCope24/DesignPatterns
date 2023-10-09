using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Repository;

public class PeopleContext : DbContext
{
    private static readonly ILoggerFactory _loggerFactory = 
        LoggerFactory.Create(builder => builder.AddConsole());

    public DbSet<Person>? People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var people = new List<Person>()
        {
            new(Guid.NewGuid(), "Mace", "Windu"),
            new(Guid.NewGuid(), "Obi", "Wan"),
            new(Guid.NewGuid(), "Master", "Yoda")
        };
        
        modelBuilder.Entity<Person>().HasData(people);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseLoggerFactory(_loggerFactory)
        .UseNpgsql("Host=localhost;Port=15432;Database=Repository;Username=postgres;Password=postgres");
    }
}