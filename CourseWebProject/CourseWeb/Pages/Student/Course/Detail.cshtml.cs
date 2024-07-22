using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Student.Course
{
    public class DetailModel : PageModel
    {
         public  ICourseService courseService;
        public ICategoryService categoryService;

        public DetailModel(ICourseService courseService,ICategoryService categoryService)
        {
            this.courseService = courseService;
            this.categoryService = categoryService;
        }
        public List<CourseDetailDTO> RelatedCourses { get; set; }

        [BindProperty]
         public CourseDetailDTO CourseDetail {  get; set; }
        public async Task OnGetAsync(int cId)
        {
             CourseDetail=await  courseService.getCourseDetailByCourseId(cId);
            RelatedCourses = await courseService.GetListCoursesBySubCategoryId(CourseDetail.SubCategoryId);
            ViewData["Categories"] = await categoryService.GetListCategory();

        }
    }
}
