using EduCore.Domain.DTOs;
using EduCore.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace EduCore.Web.Pages.Student.Course
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
            var userJson = HttpContext.Session.GetString("User");
            if (userJson != null)
            {
                var u = JsonConvert.DeserializeObject<UserDTO>(userJson);
                ViewData["NumberCourseCart"] = (await courseService.GetListCourseByStudentId(u.UserId, true)).Count();
            }
            CourseDetail =await  courseService.GetCourseDetailByCourseId(cId);
            RelatedCourses = await courseService.GetListCoursesBySubCategoryId(CourseDetail.SubCategoryId);
            ViewData["Categories"] = await categoryService.GetListCategory();

        }
    }
}
