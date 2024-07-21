using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetListUser();
        public Task<UserDTO> GetUserById(int userId);
        Task UpdateUserPartial(int userId, UserDTO userDTO);
        Task AddUser(UserDTO userDTO);
        Task DeleteUser(int userId);
    }
}
