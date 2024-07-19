using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class InstructorDTO : UserDTO
    {
        [JsonPropertyOrder(9)]
        public Decimal Rating { get; set; }

        [JsonPropertyOrder(10)]
        public int NumberStudent {  get; set; }

        [JsonPropertyOrder(11)]
        public int NumberCourse {  get; set; }

        [JsonPropertyOrder(12)]
        public List<SubCategoryDTO> SubCategories {  get; set; }


    }
}
