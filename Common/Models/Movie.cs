namespace Common.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDateTime { get; set; }
    }
}
