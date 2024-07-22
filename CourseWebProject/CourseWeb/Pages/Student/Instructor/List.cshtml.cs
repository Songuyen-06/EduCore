using CourseDomain.DTOs;
using CourseWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseWeb.Pages.Student.Instructor
{
    public class ListModel : PageModel
    {
        IInstructorService _instructorService;

        public ListModel(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [BindProperty]
        public List<InstructorDTO> Instructors { get; set; }
        public async void OnGet()
        {
            Instructors = await _instructorService.GetListInstructor();
        }

    }
}
