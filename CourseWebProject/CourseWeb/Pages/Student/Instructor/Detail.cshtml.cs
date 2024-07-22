using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Student.Instructor
{
    public class DetailModel : PageModel
    {
        IInstructorService _instructorService;
        ICourseService _courseService;
        public ICategoryService categoryService;


        public DetailModel(IInstructorService instructorService,ICourseService courseService, ICategoryService categoryService)
        {
            _instructorService = instructorService;
            _courseService = courseService;
            this.categoryService = categoryService;
        }
        [BindProperty]
          public InstructorDetailDTO InstructorDetail { get; set; }

        [BindProperty]
          public List<CourseDetailDTO>   RelatedCourses {  get; set; }
        public async Task<IActionResult> OnGetAsync(int insId)
        {
            InstructorDetail = await _instructorService.GetInstructorDetailById(insId);
            RelatedCourses= await _courseService.GetListRelatedCourseBySubcates(InstructorDetail.SubCategoryDetails);
            ViewData["Categories"] = await categoryService.GetListCategory();

            return Page();
        }
    }
}
