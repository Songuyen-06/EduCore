using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Instructor
{
    public class AddCourseModel : PageModel
    {
        private readonly ISubCategoryService _subCategoryService;

        [BindProperty]
        public List<SubCategoryDTO> SubCategories { get; set; } = new List<SubCategoryDTO>();

        public AddCourseModel(ISubCategoryService subCategoryService, ICourseService courseService)
        {
            _subCategoryService = subCategoryService ?? throw new ArgumentNullException(nameof(subCategoryService));
        }

        public async Task OnGetAsync(int instructorId)
        {
            SubCategories = await _subCategoryService.GetAllSubCategory();
        }
        public async Task<RedirectToPageResult> OnPostAsync(CourseDTO course)
        {
            if (course.Price != null && !string.IsNullOrEmpty(course.Title) && !string.IsNullOrEmpty(course.Duration)
                 && !string.IsNullOrEmpty(course.Description) && !string.IsNullOrEmpty(course.Level) && !string.IsNullOrEmpty(course.Url))
             {
                HttpClient _httpClient = new HttpClient();
                var formData = new MultipartFormDataContent
                {
                    { new StringContent(course.SubCategoryId.ToString()), "subCategoryId" },
                    { new StringContent(course.Title.ToString()), "title" },
                    { new StringContent(course.Description), "description" },
                    { new StringContent("2"), "instructorId" },
                    { new StringContent(course.Rating.ToString()), "rating" },
                    { new StringContent(course.Level), "level" },
                    { new StringContent(course.Price.ToString()), "price" },
                    { new StringContent(course.Sale.ToString()), "sale" },
                    { new StringContent(course.Url), "url" },
                    { new StringContent(course.Duration), "duration" }

                };
                    HttpResponseMessage response = await _httpClient.PostAsync("https://localhost:7004/api/Course/addCourse", formData);
            }
            return RedirectToPage("/Instructor/Index");

        }
    }
}
