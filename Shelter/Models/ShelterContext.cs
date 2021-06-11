using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public ShelterContext(DbContextOptions<ShelterContext> options) : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Captian Furbossa", AdoptionStatus = "unadopted", Biography = "Likes green apples, long walks on the beach, and eyepatches", Type = "dog", Breed = "Pitbull Mix", HasShots = true, FluffinessLevel = 6 },
          new Animal { AnimalId = 2, Name = "Pawme Amidala", AdoptionStatus = "pending", Biography = "Likes looking out windows, chasing lasers, and adventuring into laundry baskets", Type = "cat", Breed = "Norwegian Forest Cat", HasShots = true, FluffinessLevel = 10 },
          new Animal { AnimalId = 3, Name = "Wicket", AdoptionStatus = "unadopted", Biography = "Likes sniffing, climbing on everything, and intelligent converstaions", Type = "dog", Breed = "Brussels Griffon Mix", HasShots = true, FluffinessLevel = 7 },
          new Animal { AnimalId = 4, Name = "Admiral Ackbark", AdoptionStatus = "unadopted", Biography = "Likes hiding things that don't belong to him, barking orders, and naps", Type = "dog", Breed = "unknown", HasShots = true, FluffinessLevel = 4 },
          new Animal { AnimalId = 5, Name = "Catsian", AdoptionStatus = "unadopted", Biography = "Likes causing chaos, destroying everything in sight, and belly rubs", Type = "cat", Breed = "Birman", HasShots = true, FluffinessLevel = 6 }
        );
    }
  }
}