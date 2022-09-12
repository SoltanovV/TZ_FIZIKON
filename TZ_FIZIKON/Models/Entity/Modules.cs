namespace TZ_FIZIKON.Models.Entity
{
    public class Modules
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public virtual Courses Courses { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string Href { get; set; }
        public int ParentId { get; set; }
        public string ExternalId { get; set; }
        public IEnumerable<Modules> External { get; set; }
        public string ContentType { get; set; }
        public string Num { get; set; }
    }
}
