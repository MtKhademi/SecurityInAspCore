using Khademi.DAL.Entities;
using Khademi.Models.Movie;

namespace Khademi.Extenttions
{
    public static class MovieExtentions
    {
        public static MovieEntity ToMovieModel(this MovieAddDto addDto) =>
            new MovieEntity
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
