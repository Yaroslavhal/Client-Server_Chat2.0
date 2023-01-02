using Authorization.Context;
using Authorization.DTO;
using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization.Services
{
    public class UsersService
    {
        private UserContext _usersContext;
        public UsersService()
        {
            _usersContext = new UserContext();
        }
        public void Add(UserDTO dto)
        {
            _usersContext.Users.Add(ConvertToUser(dto));
            _usersContext.SaveChanges();
        }
        public void Remove(UserDTO dto)
        {
            _usersContext.Users.Remove(ConvertToUser(dto));
            _usersContext.SaveChanges();
        }
        public bool Check(UserDTO dto)
        {
            foreach(User user in _usersContext.Users)
            {
                if (user.Email == dto.Email && user.Password == dto.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckEmail(string email)
        {
            foreach (User user in _usersContext.Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        protected UserDTO ConvertToDTO(User user)
        {
            return new UserDTO() { Id = user.Id, Email = user.Email, Password = user.Password };
        }
        protected User ConvertToUser(UserDTO dto)
        {
            return new User() { Email = dto.Email, Password = dto.Password };
        }
    }
}
