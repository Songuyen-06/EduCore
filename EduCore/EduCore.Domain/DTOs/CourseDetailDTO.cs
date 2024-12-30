using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace EduCore.Domain.DTOs
{
    public class CourseDetailDTO:CourseDTO
    {
        [Key]
        [JsonPropertyOrder(2)]
        public string? SubCategoryName { get; set; }

        [JsonPropertyOrder(6)]
        public string? InstructorName { get; set; }

        [JsonPropertyOrder(8)]
        public int? RatingNumber { get; set; }

        [JsonPropertyOrder(9)]
        public int? StudentNumber { get; set; }


        [JsonPropertyOrder(13)]
        public decimal? PriceAfterSale { get; set; }

        [JsonPropertyOrder(14)]
        public int? SectionNumber { get; set; }

        [JsonPropertyOrder(15)]
        public int? LectureNumber { get; set; }

        [JsonPropertyOrder(16)]
        public List<SectionDTO>? Sections { get; set; }

        [JsonPropertyOrder(17)]
        public List<ReviewDTO>? Reviews { get; set; }
    }

}
