using CourseDomain.Contracts;
using System.ComponentModel.DataAnnotations;

namespace CourseDomain.DTOs
{
    public class PartialCourseDTO
    {

        public int? SubCategoryId { get; set; }

        public string Title { get; set; }
        public string? Description { get; set; }


        public int? InstructorId { get; set; }
        public decimal? Rating { get; set; }
        public string? Level { get; set; }
        public decimal?Price { get; set; }
        public int ?Sale { get; set; }
        public string? Url { get; set; }
        public string? Duration { get; set; }
    }
}
