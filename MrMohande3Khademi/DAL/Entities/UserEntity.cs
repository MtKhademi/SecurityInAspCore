﻿namespace MrMohande3Khademi.DAL.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public List<UserRoleEntity> Roles { get; set; } = [];
    }
}
