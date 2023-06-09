using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParksController : ControllerBase
{
  private readonly ParksLookupApiContext _db;

  public ParksController(ParksLookupApiContext db)
  {
    _db = db;
  }

  // GET api/parks
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Park>>> GetAllParksAsync()
  {
    return await _db.Parks.ToListAsync();
  }

  // GET api/parks/3
  [HttpGet("{id}")]
  public async Task<ActionResult<Park>> GetParkAsync(int id)
  {
    var park = await _db.Parks.FindAsync(id);

    if (park == null)
    {
      return NotFound();
    }

    return park;
  }

  // POST api/parks
  [HttpPost]
  public async Task<ActionResult<Park>> PostParkAsync(Park park)
  {
    _db.Parks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetParkAsync), new { id = park.ParkId }, park);
  }
}
