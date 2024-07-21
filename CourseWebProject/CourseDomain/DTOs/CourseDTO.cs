using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class CourseDTO
    {
        [Key]
        public int CourseId { get; set; }
        public string? SubCategoryName { get; set; } = null;
        public string Title { get; set; }
        public string Description { get; set; }
        public string? InstructorName { get; set; } = null;
        public decimal Rating { get; set; }
        public int? RatingNumber { get; set; } = null;
        public int? StudentNumber { get; set; } = null;

        public string Level { get; set; }

        public decimal Price { get; set; }
        public int Sale { get; set; }
        public decimal? PriceAfterSale { get; set; } = null;

        public int? SubCategoryId { get; set; } = null;
        public string Duration { get; set; }
        public int? SectionNumber { get; set; } = null;
        public int? LectureNumber { get; set; } = null;

        public string? UrlImage {  get; set; } = null;


    }

}
