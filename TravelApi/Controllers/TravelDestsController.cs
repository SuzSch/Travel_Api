using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TravelDestsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public TravelDestsController(TravelApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<List<TravelDest>> Get(string cityName, string countryName, int rating, int minimumRating, string review, int numberOfReviews)
    {
      IQueryable<TravelDest> query = _db.TravelDests.AsQueryable();

      if (cityName != null)
      {
        query = query.Where(entry => entry.CityName.Contains(cityName));
      }

      if (countryName != null)
      {
        query = query.Where(entry => entry.CountryName.Contains(countryName));
      }

      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return await query.ToListAsync();

      if (minimumRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minimumRating);
      }
      return await query.ToListAsync();

      if (review != null)
      {
        query = query.Where(entry => entry.Review.Contains(review));
      }

      if (numberOfReviews > 0)
       {
       query = query.Where(entry => entry.Review.Count() == numberOfReviews);
       }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TravelDest>> GetTravelDest(int id)
    {
      TravelDest travelDest = await _db.TravelDests.FindAsync(id);
      if (travelDest == null)
      {
        return NotFound();
      }
      return travelDest;
    }
    [HttpPost]
    public async Task<ActionResult<TravelDest>> Post(TravelDest travelDest)
    {
      _db.TravelDests.Add(travelDest);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetTravelDest), new { id = travelDest.TravelDestId }, travelDest);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TravelDest travelDest)
    {
      if (id != travelDest.TravelDestId)
      {
        return BadRequest();
      }
      _db.TravelDests.Update(travelDest);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!TravelDestExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool TravelDestExists(int id)
    {
      return _db.TravelDests.Any(e => e.TravelDestId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTravelDest(int id)
    {
      TravelDest travelDest = await _db.TravelDests.FindAsync(id);
      if (travelDest == null)
      {
        return NotFound();
      }

      _db.TravelDests.Remove(travelDest);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
