using Common.Models;

namespace Common
{
    public static class DatabaseContext
    {

        public static List<MovieModel> Movies;
        public static List<UserModel> Users;
        static DatabaseContext()
        {
            Movies =
            [
                new MovieModel
                {
                    CreateDateTime = DateTime.Now,
                    DeletedDateTime = DateTime.Now,
                    Id = 1,
                    IsDeleted = true,
                    Name = "Movie 1",
                    Rate = 10,
                    UpdateDateTime = DateTime.Now
                },
            ];

            Users =
             [
                 new UserModel
                 {
                     Id = 1,
                     BirthDate = DateTime.Now,
                     Password = "123",
                     UpdateDateTime = DateTime.Now,
                     UserName = "mt.khademi",
                     Role = "Administrator"
                 },
                 new UserModel
                 {
                     Id = 2,
                     BirthDate = DateTime.Now,
                     Password = "123",
                     UpdateDateTime = DateTime.Now,
                     UserName = "mt",
                     Role = "Seller"
                 },
                 new UserModel
                 {
                     Id = 3,
                     BirthDate = DateTime.Now,
                     Password = "123",
                     UpdateDateTime = DateTime.Now,
                     UserName = "khademi",
                     Role = "User"
                 }
             ];

        }

    }
}
