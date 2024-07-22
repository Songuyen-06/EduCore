using CourseDomain;
using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Student.Instructor
{
    public class ListModel : PageModel
    {
        IInstructorService _instructorService;
        ICategoryService _categoryService;

        public ListModel(IInstructorService instructorService, ICategoryService categoryService)
        {
            _instructorService = instructorService;
            _categoryService = categoryService;
        }
        [BindProperty]
        public List<InstructorDTO> Instructors { get; set; }

        public async Task OnGetAsync(int? cateId, int? subCateId)
        {
            int categoryId = cateId ?? 1;
            ViewData["CateId"] = categoryId;
            ViewData["SubCateId"] = subCateId;
            Instructors = await _instructorService.GetListInstructorByFilter(categoryId, subCateId);

            ViewData["Categories"] = await _categoryService.GetListCategory(); 
            ViewData["NumberPage"] = _instructorService.GetNumberPageInstructor(Instructors.Count);
            
        }

    }
}
