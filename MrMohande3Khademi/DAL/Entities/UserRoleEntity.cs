namespace MrMohande3Khademi.DAL.Entities
{
    public class UserRoleEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public UserEntity User { get; set; } = null!;


        public int RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;
    }
}
