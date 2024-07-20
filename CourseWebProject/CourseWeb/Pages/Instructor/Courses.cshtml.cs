using CourseServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Instructor
{
    public class CoursesModel : PageModel
    {
        private ICourseService courseService;
        [BindProperty]
        private  List<CourseDomain.DTOs.CourseDTO> courses {  get; set; }
        public  CoursesModel(CourseService courseService, List<CourseDomain.DTOs.CourseDTO> courses)
        {
            this.courses = courses;
            this.courseService = courseService;
        }
        public void OnGet()
        {
            courses =   courseService.GetListCourseByInstructorId();

        }
    }
}
