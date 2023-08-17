using Microsoft.EntityFrameworkCore;
// using DinoApi.Models;

namespace DinoApi.Models
{
  public class DinoApiContext : DbContext
  {
    public DbSet<Dino> Dinos { get; set; }
    public DinoApiContext(DbContextOptions<DinoApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dino>()
        .HasData(
          new Dino { DinoId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7 },
          new Dino { DinoId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10 },
          new Dino { DinoId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2 },
          new Dino { DinoId = 4, Name = "Pip", Species = "Shark", Age = 4 },
          new Dino { DinoId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22 }
        );
    }
  }
}