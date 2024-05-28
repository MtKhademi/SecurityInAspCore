namespace _003_WriteOwn.Models.Movie
{
    public class MovieGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
