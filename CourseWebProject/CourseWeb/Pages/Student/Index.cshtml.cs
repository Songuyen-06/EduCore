using CourseDomain;
using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;

namespace CourseWeb.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private ICategoryService _categoryService { get; set; }
        private ICourseService _courseService { get; set; }

        private IReviewService _reviewService { get; set; }

        private IInstructorService _instructorService { get; set; }

        [BindProperty]
        public List<CourseDetailDTO> TopSellingCourses { get; set; }

        //private List<CategoryDTO> Categories { get; set; }

        [BindProperty]

        public List<InstructorDTO> Instructors { get; set; }

        [BindProperty]
        public List<ReviewDTO> Reviews { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICategoryService categoryService, ICourseService courseService, IReviewService reviewService, IInstructorService instructorService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _courseService = courseService;
            _reviewService = reviewService;
            _instructorService = instructorService;
        }

        public async Task OnGetAsync(int? cateId)
        {

            ViewData["Categories"] = await _categoryService.GetListCategory();
            TopSellingCourses = cateId != null ? await _courseService.GetTopSellingCoursesByCateId(cateId) : await _courseService.GetTopSellingCourses();
            Reviews = await _reviewService.GetListReview();
            Instructors = await _instructorService.GetListInstructor();
            ViewData["CateId"] = cateId;

        }
    }
}
