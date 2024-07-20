using CourseDomain.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CourseDomain.DTOs
{
    public class CourseDTO
    {
        [Key]
        [JsonPropertyOrder(0)]
        public int CourseId { get; set; }

        [JsonPropertyOrder(1)]
        public int? SubCategoryId { get; set; }

        [JsonPropertyOrder(3)]
        public string Title { get; set; }
        [JsonPropertyOrder(4)]
        public string? Description { get; set; }


        [JsonPropertyOrder(5)]
        public int? InstructorId { get; set; }

        [JsonPropertyOrder(7)]
        public decimal? Rating { get; set; }

        [JsonPropertyOrder(10)]
        public string? Level { get; set; }

        [JsonPropertyOrder(11)]
        public decimal?Price { get; set; }

        [JsonPropertyOrder(12)]
        public int ?Sale { get; set; }

        [JsonPropertyOrder(16)]
        public string? Url { get; set; }

        [JsonPropertyOrder(17)]
        public string? Duration { get; set; }
    }
}
