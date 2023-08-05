namespace MovieManagement.Domain.Entities
{
    public class Biography
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Actor? Actor { get; set; }
        public int ActorId { get; set; }
    }
}