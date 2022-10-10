using Prototype_backend.Models;

namespace Prototype_backend.Data
{
    public class BeerService
    {
        private readonly Prototype_backendContext _context;

        public BeerService(Prototype_backendContext context)
        {
            _context = context;
        }

        public List<Beer> GetBeers()
        {
            return _context.Beer.ToList();
        }

        public void CreateBeer(Beer beer)
        {
            _context.Add(beer);
            _context.SaveChanges();
        }
    }
}
