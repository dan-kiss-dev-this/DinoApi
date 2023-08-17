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
  }
}