using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.User
{
    public class EditModel : PageModel
    {
        private readonly IUserService _userService;
        public EditModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public UserDTO User { get; set; }

        public async Task<IActionResult> OnGet(int userid)
        {
            User = await _userService.GetUserById(userid);
            if (User == null)
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

            var result = await _userService.UpdateUser(User);
            if (result)
            {
                TempData["SuccessMessage"] = "User updated successfully.";
                return Page();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "An error occurred while updating the user.");
                return Page();
            }
        }
    }
}
