using MrMohande3Khademi.DAL.Entities;

namespace MrMohande3Khademi.DAL
{
    public static class SeedData
    {
        public static List<MovieEntity> Movies =>
                [
                    new MovieEntity()
                    {
                        Id = 1,
                        CreateDateTime = DateTime.Now,
                        Description = "",
                        CreatedBy = "Mt.khademi",
                        IsDeleted = false,
                        Name = "Movie 001",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new MovieEntity()
                    {
                        Id = 2,
                        CreateDateTime = DateTime.Now,
                        Description = "",
                        CreatedBy = "Brother warner",
                        IsDeleted = false,
                        Name = "Movie 002",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new MovieEntity()
                    {
                        Id = 3,
                        CreateDateTime = DateTime.Now,
                        Description = "",
                        CreatedBy = "Pixar",
                        IsDeleted = false,
                        Name = "Movie 003",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new MovieEntity()
                    {
                        Id = 4,
                        CreateDateTime = DateTime.Now,
                        Description = "",
                        CreatedBy = "Alibaba",
                        IsDeleted = false,
                        Name = "Movie 004",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    },
                    new MovieEntity()
                    {
                        Id = 5,
                        CreateDateTime = DateTime.Now,
                        Description = "",
                        CreatedBy = "Vedio Full intertanment",
                        IsDeleted = false,
                        Name = "Movie 005",
                        Rate = 10,
                        UpdateDateTime = DateTime.Now,
                        InsertDateTime = DateTime.Now
                    }
                ];

        public static List<RoleEntity> Roles =>
            [
                new RoleEntity() { Id = 1 , Name = "administrator", ControllerAccess = "movie" },
                new RoleEntity() { Id = 2, Name = "user", ControllerAccess = "" }
            ];
    }
}
