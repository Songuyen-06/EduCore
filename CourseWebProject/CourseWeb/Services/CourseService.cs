
using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public CourseDTO CreateCourse(CourseDTO course)
        {
            return null;
        }

        public async Task<CourseDTO> getCourseByCourseId(int courseId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getCourseByCourseId/{courseId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CourseDTO>();
        }

        public async Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseByInstructorId/{instructorId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }

       

        public async Task<List<CourseDTO>> GetListCoursesByCategoryId(int cateId)
        {          
          
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseByCategoryId/{cateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }



        public async Task<List<CourseDTO>> GetListCoursesBySubCategoryId(int? subCateId)
        {
           
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseBySubCategoryId/{subCateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }


        

        public int GetNumberPageCourse(int numberCourse)
        {            
            var numberPage = numberCourse / 8;
            if (numberCourse % 8 != 0)
            {
                numberPage += 1;
            }
            return numberPage;
        }

        public async Task<List<CourseDTO>> GetTopSellingCourses()
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Course/GetTopSellingCourses").Result.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }
        public async Task<List<CourseDTO>> GetTopSellingCoursesByCateId(int? cateId)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Course/GetTopSellingCoursesByCateId/{cateId}").Result.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }

        
    }
}
