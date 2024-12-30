using EduCore.Domain.DTOs;
using System.Collections;

namespace EduCore.Web.Services
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(int id);
        Task<bool> CreateUser(UserDTO user);
        public Task<UserDTO> GetUserByEmailAndPassword(UserDTO u);
        public Task<List<UserDTO>> GetListUser();
        Task<bool> UpdateUser(UserDTO user);
        Task DeleteUser(int userId);
        public Task<int> GetNumberUser();

    }
}
