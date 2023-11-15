using Microsoft.EntityFrameworkCore;

namespace AnimalsApi.Models
{
  public class AnimalsApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalsApiContext(DbContextOptions<AnimalsApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Species="Canine", Name = "Matilda", Description = "Long black hair, no tail" },
          new Animal { AnimalId = 2, Species="Feline", Name = "Chumley", Description = "Orange, white spots." },
          new Animal { AnimalId = 3, Species="Feline", Name = "Missy", Description = "Simese" }
        );
    }
  }
}