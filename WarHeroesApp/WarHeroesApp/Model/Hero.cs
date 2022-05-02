namespace WarHeroesApp.Model
{
    public class Hero
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Rank Rank { get; init; }
    }
}
