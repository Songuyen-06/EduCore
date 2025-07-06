using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetListUser();
        Task UpdateUser(UserDTO userDTO);
        Task AddUser(UserDTO userDTO);
        Task DeleteUser(int userId);
        Task UpdateStatusUser(UserStatusDTO userStatus);
        public Task<UserDTO> GetUserById(int userId);
    }
}
