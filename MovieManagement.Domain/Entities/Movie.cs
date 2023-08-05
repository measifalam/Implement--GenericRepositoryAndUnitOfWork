namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
        public Genre? Genre { get; set; }
    }
}