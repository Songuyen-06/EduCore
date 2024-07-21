using CourseDomain;
using CourseDomain.DTOs;
using CourseWeb.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

namespace CourseWeb.Pages.Instructor
{
    public class CoursesModel : PageModel
    {
        private readonly ICourseService _courseService;
        private readonly ISectionService _sectionService;
        private readonly HttpClient _httpClient;
        [BindProperty]
        public List<SectionDTO> Sections { get; set; }
        [BindProperty]
        public List<CourseDTO> ListCourse { get; set; }
        public CoursesModel(ICourseService courseService, ISectionService sectionService, HttpClient httpClient)
        {
            _courseService = courseService;
            _sectionService = sectionService;
            _httpClient = httpClient;
        }
        public async Task OnGetAsync( int instructorId)
        {

            
            ListCourse = await _courseService.GetListCourseByInstructorId(instructorId);
        }
    }
}