namespace TZ_FIZIKON.Models.Entity
{
    public class Courses
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string ExternalId { get; set; }
        public string Hash { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }
        public string Genre { get; set; }
        
        public virtual IEnumerable<Modules> Modules { get; set; }

    }
}
