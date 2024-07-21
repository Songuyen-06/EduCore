using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<bool> CreateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetUserByEmailAndPassword(UserDTO u)
        {
            var res = _httpClient.GetAsync($"{_baseAPIRoute}/User?$filter=email eq {u.Email} and password eq {u.Password}").Result;
            if (res.IsSuccessStatusCode)
            {
                return await res.Content.ReadFromJsonAsync<UserDTO>();
            }
            return null;
        }
    }
}
