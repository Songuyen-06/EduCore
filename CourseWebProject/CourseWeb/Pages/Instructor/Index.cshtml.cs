using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Instructor
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;

        [BindProperty]
        public int TotalCourse { get; set; }

        [BindProperty]
        public int TotalStudent { get; set; }

        [BindProperty]
        public int instructorId { get; set; }
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task OnGetAsync()
        {
            var courses = await _courseService.GetListCourseByInstructorId(2);
            TotalCourse = courses.Count;
            TotalStudent = (int)courses.Sum(course => course.StudentNumber);
            instructorId = 2;
        }
    }
}
