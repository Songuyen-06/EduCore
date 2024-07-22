using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

namespace CourseWeb.Pages.Sections
{
    public class IndexModel : PageModel
    {
        private readonly ISectionService _sectionService;
        private readonly HttpClient _httpClient;
        private readonly ICourseService _courseService;
        [BindProperty]
        public List<SectionDTO> Sections { get; set; }

        [BindProperty]
        public CourseDTO Course { get; set; }

        public IndexModel(ISectionService sectionService, HttpClient httpClient, ICourseService courseService)
        {
            _sectionService = sectionService;
            _httpClient = httpClient;
            _courseService = courseService;
        }

        public async Task OnGetAsync(int courseId)
        {
            
            Course = await _courseService.getCourseDetailByCourseId(courseId);
            Sections = await _sectionService.GetAllSectionByCourseId(courseId);
        }
    }
}
