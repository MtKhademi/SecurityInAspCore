using MrMohande3Khademi.DAL.Entities;
using MrMohande3Khademi.Models.Movie;

namespace MrMohande3Khademi.Extenttions
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
