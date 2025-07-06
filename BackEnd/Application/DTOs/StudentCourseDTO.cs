using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.DTOs
{
    public class  StudentCourseDTO
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public bool IsInCart { get; set; }
    }
}
