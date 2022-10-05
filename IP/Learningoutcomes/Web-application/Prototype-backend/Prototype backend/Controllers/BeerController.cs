using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype_backend.Models;

namespace Prototype_backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : Controller
    {
        public Beer beer = new();

        [HttpGet]
        public JsonResult Beers()
        {
            List<Beer> beers = new();
            Beer beer1 = new();
            beer1.Name = "La Chouffe";
            beer1.Description = "Nice beer";
            beer1.AlcoholPercentage = 5;
            beers.Add(beer1);
            return Json(beers);
        }
    }
}
