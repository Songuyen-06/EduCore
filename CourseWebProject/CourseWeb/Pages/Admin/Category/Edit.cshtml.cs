using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.Category
{
    public class EditModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public EditModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
        public CategoryDTO Category { get; set; }
       
        public async Task<IActionResult> OnGetAsync(int categoryId)
        {
            Category = await _categoryService.GetCategoryByCateId(categoryId);
            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var success = await _categoryService.UpdateCategory(Category);
            if (success)
            {
                return RedirectToPage("/Admin/Category/ListCategory");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Failed to update category.");
                return Page();
            }
        }
    }
}
