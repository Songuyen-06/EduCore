using CourseDomain.DTOs;
using CourseInfrastructure;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.OData.ModelBuilder;

namespace CourseWeb.Pages.Admin.User
{
    public class ListUserModel : PageModel
    {
        private readonly IUserService _userService;
        public ListUserModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public List<UserDTO> Users { get; set; }
        public async Task OnGetAsync()
        {
           var users = await _userService.GetListUser();
            Users = users;
        }
        public async Task<IActionResult> OnPostDeleteAsync(int userId)
        {
            try
            {
                await _userService.DeleteUser(userId);
                return RedirectToPage("./ListUser"); 
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
