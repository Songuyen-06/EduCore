using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class SectionDTO
    {
        [Key]
        public int SectionId { get; set; }
        public string Title { get; set; }

        public int LectureNumber { get; set; }

        public TimeSpan  Duration { get; set; }

        public List<LectureDTO> Lectures { get; set; }
    }
}
