
using System.Net.Http;

namespace EduCore.Web.Services
{
    public class StudentService : IStudentService

    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<int> GetNumberStudents()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/User/$count?$filter=roleId eq 1").Result.Content.ReadFromJsonAsync<int>();
        }
    }
}
