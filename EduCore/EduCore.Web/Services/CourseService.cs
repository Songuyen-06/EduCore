
using EduCore.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace EduCore.Web.Services
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

        public async Task<CourseDetailDTO> GetCourseDetailByCourseId(int courseId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getCourseDetailByCourseId/{courseId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CourseDetailDTO>();
        }

        public async Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseByInstructorId/{instructorId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CourseDTO>>();
        }



        public async Task<List<CourseDetailDTO>> GetListCoursesByCategoryId(int cateId)
        {

            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseByCategoryId/{cateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        }
        public async Task<int> GetNumberCourses()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/Course/$count").Result.Content.ReadFromJsonAsync<int>();

        }


        public async Task<List<CourseDetailDTO>> GetListCoursesBySubCategoryId(int? subCateId)
        {

            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseBySubCategoryId/{subCateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        }

        public async Task<List<CourseDetailDTO>> GetListRelatedCourseBySubcates(List<SubCategoryDetailDTO> subCategories)
        {
            var allCourses = new List<CourseDetailDTO>();

            foreach (var sub in subCategories)
            {
                var courses = await GetListCoursesBySubCategoryId(sub.SubCategoryId);
                if (courses != null)
                {
                    allCourses.AddRange(courses);
                }
            }

            return allCourses;
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

        public async Task<List<CourseDetailDTO>> GetTopSellingCourses()
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Course/GetTopSellingCourses").Result.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        }
        public async Task<List<CourseDetailDTO>> GetTopSellingCoursesByCateId(int? cateId)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Course/GetTopSellingCoursesByCateId/{cateId}").Result.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        }


        public async Task<List<CourseDetailDTO>> GetListCourseByStudentId(int stId,bool isInCart)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Course/getListCourseByStudentId/{stId}/{isInCart}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        }
        public async Task<int> AddStudentCourse(StudentCourseDTO stC)
        {
            var json = JsonSerializer.Serialize(stC);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_baseAPIRoute}/Course/addStudentCourse", content);

            return response.IsSuccessStatusCode ? 1 : -1;
        }
    }
}
