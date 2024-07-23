using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.User
{
    public class AddModel : PageModel
    {
        private readonly IUserService _userService;

        public AddModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserDTO User { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await _userService.CreateUser(User);
            if (result)
            {
                return RedirectToPage("/Admin/User/ListUser"); 
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Có l?i x?y ra khi thêm ng??i dùng.");
                return Page();
            }
        }
    }
}
