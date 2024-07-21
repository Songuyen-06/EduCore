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
            try
            {
                // Make the asynchronous GET request
                var response = await _httpClient.GetAsync($"{_baseAPIRoute}/User/getListUser?$filter=email eq '{u.Email}' and password eq '{u.Password}'");

                // Ensure the request was successful
                if (response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadFromJsonAsync<List<UserDTO>>();
                    return user.FirstOrDefault();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
