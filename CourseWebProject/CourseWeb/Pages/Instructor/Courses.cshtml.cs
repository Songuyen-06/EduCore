using CourseDomain.DTOs;
using CourseWeb.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Instructor
{
    public class CoursesModel : PageModel
    {
        private readonly ICourseService _courseService;

        [BindProperty]
        public List<CourseDTO> ListCourse { get; set; }
        public CoursesModel( ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task OnGetAsync( int instructorId)
        {
            ListCourse = await _courseService.GetListCourseByInstructorId(instructorId);
        }
    }
}