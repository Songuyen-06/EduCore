using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseDomain;
using CourseServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.OData.Query;
using CourseDomain.DTOs;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getListCourseByStudentId/{stdId}/{isInCart}")]
        public async Task<IActionResult> GetListCourseByStudentId(int stdId, bool isInCart)
        {
            var courses = await _courseService.GetListCourseByStudentId(stdId, isInCart);
            return Ok(courses);
        }

        [HttpGet("getListCourseByInstructorId/{id}")]
        public async Task<IActionResult> GetListCourseByInstructorId(int id)
        {
            var courses = await _courseService.GetListCourseByInstructorId(id);
            return Ok(courses);
        }

        // GET: api/Course
        [HttpGet("getCourseByCourseId/{courseId}")]
        public async Task<IActionResult> GetCourseByCourseId(int courseId)
        {
            var courses = await _courseService.GetCourseByCourseId(courseId);


            return Ok(courses);

        }

        [HttpGet("getListCourse")]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            var courses = await _courseService.GetListCourse();


            return Ok(courses);
        }
        [HttpGet("getListCourseBySubCategoryId/{subCateId}")]
        [EnableQuery]
        public async Task<IActionResult> GetListCourseBySubCategoryId(int subCateId)
        {
            var courses = await _courseService.GetListCourseBySubCategoryId(subCateId);


            return Ok(courses);
        }

        [HttpGet("getListCourseByCategoryId/{cateId}")]
        [EnableQuery]
        public async Task<IActionResult> GetListCourseByCategoryId(int cateId)
        {
            var courses = await _courseService.GetListCourseByCategoryId(cateId);

            return Ok(courses);
        }



        [HttpPost("addStudentCourse")]
        public async Task<IActionResult> AddStudentCourse([FromBody] StudentCourseDTO scDTO)
        {
            await _courseService.AddStudentCourse(scDTO);

            return Ok();
        }



        [HttpPost("addCourse")]
        public async Task<IActionResult> AddCourse([FromBody] PartialCourseDTO cDTO)
        {
            await _courseService.AddCourse(cDTO);

            return Ok();
        }


        [HttpPost("updateCourse/{courseId}")]
        public async Task<IActionResult> UpdateCourse([FromBody] PartialCourseDTO cDTO, int courseId)
        {
            await _courseService.UpdateCourse(cDTO, courseId);

            return Ok();
        }

        [HttpGet("getTopSellingCourses")]
        public async Task<IActionResult> GetTopSellingCourses()
        {
            return Ok(await _courseService.GetTopSellingCourses());

        }
        [HttpGet("getTopSellingCoursesByCateId/{cateId}")]
        public async Task<IActionResult> GetTopSellingCoursesByCateId(int cateId)
        {
            return Ok(await _courseService.GetListCourseByCategoryId(cateId));

        }

    }
}
