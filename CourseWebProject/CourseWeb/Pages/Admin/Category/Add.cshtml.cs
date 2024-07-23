using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.Category
{
    public class AddModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public AddModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [BindProperty]
        public CategoryDTO Category { get; set; } = new CategoryDTO { SubCategories = new List<SubCategoryDTO>() };

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _categoryService.AddCategory(Category);
            return RedirectToPage("/Admin/Category/ListCategory");
        }
    }
}
