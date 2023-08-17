using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DinoApi.Models;

namespace DinoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DinosController : ControllerBase
  {
    private readonly DinoApiContext _db;

    public DinosController(DinoApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dino>>> Get()
    {
      return await _db.Dinos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dino>> GetDino(int id)
    {
      Dino dino = await _db.Dinos.FindAsync(id);
      if (dino == null)
      {
        return NotFound();
      }
      return dino;
    }
  }
}