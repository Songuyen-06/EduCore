using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public  class LectureDTO
    {
        [Key]
        public int LectureId { get; set; }


        public string Title { get; set; } = null!;

        public string? Content { get; set; }

        public string? VideoUrl { get; set; }

        public string? Duration { get; set; }


    }
}
