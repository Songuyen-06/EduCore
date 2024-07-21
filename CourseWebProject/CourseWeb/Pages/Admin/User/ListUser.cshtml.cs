using CourseDomain.DTOs;
using CourseInfrastructure;
using CourseServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Admin.User
{
    public class ListUserModel : PageModel
    {
        private readonly IUserService _userService;
        public ListUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public List<UserDTO> Users { get; set; }
        public async Task OnGetAsync()
        {
            Users = await _userService.GetListUser();
        }
    }
}
