using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;

        public IndexModel(IUserService userService,ICategoryService categoryService)
        {
            _userService = userService;
            _categoryService = categoryService;
        }
       
        [BindProperty]
        public List<UserDTO> Users { get; set; }

        [BindProperty]
        public int TotalUsers { get; set; }

        [BindProperty]
        public int TotalCates { get; set; }

        public async Task OnGetAsync()
        {
          
            
            var users = await _userService.GetListUser();
            Users = users;
            TotalUsers = await _userService.GetNumberUser();
            TotalCates = await _categoryService.GetNumberCategories();
        }
    }
}
