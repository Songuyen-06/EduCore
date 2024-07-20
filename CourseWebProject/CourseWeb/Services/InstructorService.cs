using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public class InstructorService : IInstructorService

    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public InstructorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<InstructorDTO>> GetListInstructor()
        {
            return _httpClient.GetAsync($"{_baseAPIRoute}/Instructor/getListInstructor").Result.Content.ReadFromJsonAsync<List<InstructorDTO>>();
        }
        public async Task<int> GetNumberInstructors()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/User/$count?$filter=roleId eq 2").Result.Content.ReadFromJsonAsync<int>();

        }
    }
}
