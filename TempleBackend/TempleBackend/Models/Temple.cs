namespace TempleBackend.Models
{
    public class Temple
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public  string? Phone { get; set; }
        public  string? Description { get; set; }
        public List<Deity>? Deities { get; set; }
    }

    public class Deity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public required string Description { get; set; }
        public  string? ImageUrl { get; set; }
    }
} 