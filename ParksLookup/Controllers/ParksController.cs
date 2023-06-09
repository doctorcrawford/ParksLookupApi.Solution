using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ParksController : ControllerBase
{
  private readonly ParksLookupApiContext _db;

  public ParksController(ParksLookupApiContext db)
  {
    _db = db;
  }

  
}
