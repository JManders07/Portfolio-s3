namespace Prototype_backend.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AlcoholPercentage { get; set; }

        public Beer()
        {

        }

        public Beer(Beer beer)
        {
            Name = beer.Name;
            Description = beer.Description;
            AlcoholPercentage = beer.AlcoholPercentage;
        }

    }
}
