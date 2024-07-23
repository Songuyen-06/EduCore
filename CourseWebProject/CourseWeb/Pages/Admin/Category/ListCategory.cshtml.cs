using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.Category
{
    public class ListCategoryModel : PageModel
    {
        private  ICategoryService _categoryService;
        public ListCategoryModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [BindProperty]
        public IEnumerable<CategoryDTO> Categories { get; set; }
        
        public async Task OnGetAsync()
        {
            Categories = await _categoryService.GetListCategory();
            
        }
        public async Task<IActionResult> OnPostDeleteAsync(int categoryId)
        {
            await _categoryService.DeleteCategory(categoryId);
            return RedirectToPage("/Admin/Category/ListCategory");
        }

    }
}
