using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public  class InstructorDetailDTO: InstructorDTO
    { 
        private List<CourseDTO> Courses {  get; set; }
        private List<ReviewDTO> Reviews { get; set; }
    }
}
