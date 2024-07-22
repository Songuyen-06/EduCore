using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CourseWeb.Pages.Home
{
    public class LoginAndSignupModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginAndSignupModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserDTO User { get; set; }

        [TempData]
        public string LoginError { get; set; }

        public async Task<IActionResult> OnGet()
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return Page();
            }
            return RedirectToPage("/Home");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userService.GetUserByEmailAndPassword(User);

            if (user != null)
            {
                var userJson = JsonConvert.SerializeObject(user);
                HttpContext.Session.SetString("User", userJson);

                switch (user.RoleId)
                {
                    case 1: // Student
                        return RedirectToPage("/Student/Index");
                    case 2: // Admin
                        return RedirectToPage("/Admin");
                    case 3: // Instructor
                        return RedirectToPage("/Instructor");
                    default:
                        LoginError = "Invalid role!";
                        return Page();
                }
            }
            else
            {
                LoginError = "Invalid email or password!";
                return Page();
            }
        }


        public async Task<IActionResult> OnPostSignup()
        {
            // Implement signup logic here

            return RedirectToPage("/Home/Index");
        }

        
    }
}
