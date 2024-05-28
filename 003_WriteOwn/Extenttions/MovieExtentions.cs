using _003_WriteOwn.Models.Movie;

namespace _003_WriteOwn.Extenttions
{
    public static class MovieExtentions
    {
        public static Movie ToMovieModel(this MovieAddDto addDto) =>
            new Movie
            {
                CreateDateTime = addDto.CreateDateTime,
                CreatedBy = addDto.CreatedBy,
                Name = addDto.Name,
                Rate = addDto.Rate,
                Description = addDto.Description,
                //-- default data
                DeletedDateTime = null,
                InsertDateTime = DateTime.Now,
                IsDeleted = false,
                UpdateDateTime = DateTime.Now
            };
    }
}
