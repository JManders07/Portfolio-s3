using Microsoft.AspNetCore.Mvc;
using Prototype_backend.Data;
using Prototype_backend.Models;
using Newtonsoft.Json;

namespace Prototype_backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeersController : Controller
    {
        private readonly BeerService _context;

        public BeersController(BeerService context)
        {
            _context = context;
        }

        // GET: api/Beers
        [HttpGet]
        public JsonResult AllBeers()
        {
            List<Beer> beers = new();
            foreach (var beer in _context.GetBeers())
            {
                beers.Add(beer);
            }
            return Json(beers);
        }

        [HttpPost]
        public string Create([FromBody] Beer beer)
        {
            if (beer != null)
            {
                try
                {
                    _context.CreateBeer(beer);
                    return "Perfect";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return "";
        }

        //    // GET: api/Beers/5
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<Beer>> GetBeer(int id)
        //    {
        //        var beer = await _context.Beer.FindAsync(id);

        //        if (beer == null)
        //        {
        //            return NotFound();
        //        }

        //        return beer;
        //    }

        //    // PUT: api/Beers/5
        //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutBeer(int id, Beer beer)
        //    {
        //        if (id != beer.Id)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(beer).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BeerExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/Beers
        //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //    [HttpPost]
        //    public async Task<ActionResult<Beer>> PostBeer(Beer beer)
        //    {
        //        _context.Beer.Add(beer);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("GetBeer", new { id = beer.Id }, beer);
        //    }

        //    // DELETE: api/Beers/5
        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> DeleteBeer(int id)
        //    {
        //        var beer = await _context.Beer.FindAsync(id);
        //        if (beer == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Beer.Remove(beer);
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }

        //    private bool BeerExists(int id)
        //    {
        //        return _context.Beer.Any(e => e.Id == id);
        //    }
        //}
    }
}
