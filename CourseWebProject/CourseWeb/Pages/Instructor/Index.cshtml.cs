using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Instructor
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;

        private readonly IStudentService _stService;

        [BindProperty]
        public int TotalCourse { get; set; }

        [BindProperty]
        public int TotalStudent { get; set; }

        [BindProperty]
        public int instructorId { get; set; }
        public IndexModel(ICourseService courseService,IStudentService studentService)
        {
            _courseService = courseService;
            _stService = studentService;
        }
        public async Task OnGetAsync()
        {
            var courses = await _courseService.GetListCourseByInstructorId(2);
            TotalCourse = courses.Count;
            TotalStudent = await _stService.GetNumberStudents();
            instructorId = 2;
        }
    }
}
