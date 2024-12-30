using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EduCore.Domain;
using EduCore.Domain.DTOs;
using EduCore.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EduCore.Web.Pages.Student.Course
{
    public class ListModel : PageModel
    {
        private readonly ILogger<ListModel> _logger;
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;

        [BindProperty]
        public List<CourseDetailDTO> Courses { get; set; }

       

        public ListModel(ILogger<ListModel> logger, ICourseService courseService, ICategoryService categoryService)
        {
            _logger = logger;
            _courseService = courseService;
            _categoryService = categoryService;
        }

        public async Task OnGetAsync(int cateId, int? subCateId)
        {
            try
            {
                var userJson = HttpContext.Session.GetString("User");
                if (userJson != null)
                {
                    var u = JsonConvert.DeserializeObject<UserDTO>(userJson);
                    ViewData["NumberCourseCart"] = (await _courseService.GetListCourseByStudentId(u.UserId, true)).Count();
                }

                Courses = subCateId!=null?await _courseService.GetListCoursesBySubCategoryId(subCateId): await _courseService.GetListCoursesByCategoryId(cateId);



                ViewData["NumberPage"] =  _courseService.GetNumberPageCourse(Courses.Count);

                ViewData["CateId"] = cateId;
                ViewData["SubCateId"] = subCateId;
              ViewData["Categories"] = await _categoryService.GetListCategory();

            }
            catch (HttpRequestException ex)
            {
                _logger.LogError($"Error fetching data from API: {ex.Message}");
            }
        }
    
    }
}