using CourseDomain.DTOs;
using System.Collections;

namespace CourseWeb.Services
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
