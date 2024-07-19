using CourseDomain;
using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;

namespace CourseWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private ICategoryService _categoryService { get; set; }
        private ICourseService _courseService { get; set; }

        private IReviewService _reviewService { get; set; }

        [BindProperty]
        public List<CourseDTO> TopSellingCourses { get; set; }

        //private List<CategoryDTO> Categories { get; set; }
        //private List<UserDTO> Instructors { get; set; }

        [BindProperty]
        public List<ReviewDTO> Reviews { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICategoryService categoryService, ICourseService courseService, IReviewService reviewService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _courseService = courseService;
            _reviewService = reviewService;
        }

        public async Task OnGetAsync(int? cateId)
        {

            ViewData["Categories"] = await _categoryService.GetListCategory();
            TopSellingCourses = cateId != null ? await _courseService.GetTopSellingCoursesByCateId(cateId) : await _courseService.GetTopSellingCourses();
            Reviews = await _reviewService.GetListReview();
            ViewData["CateId"] = cateId;

        }
    }
}

