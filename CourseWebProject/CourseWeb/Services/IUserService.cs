using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface IUserService
    {
        Task<bool> CreateUser(UserDTO user);
        public Task<UserDTO> GetUserByEmailAndPassword(UserDTO u);
    }
}
