using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        private readonly string APIRoute = "https://localhost:7004/api";

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }

        public async Task<CategoryDTO> GetCategoryByCateId(int cateId)
        {
            var response = await _httpClient.GetAsync($"{APIRoute}/Category/GetCategoryByCateId/{cateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CategoryDTO>();

        }
        public async Task<List<CategoryDTO>> GetListCategory()
        {
            var response = await _httpClient.GetAsync($"{APIRoute}/Category/GetListCategory");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CategoryDTO>>();
        }
        
    }
}
