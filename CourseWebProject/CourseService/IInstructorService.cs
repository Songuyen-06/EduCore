using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public  interface IInstructorService
    {
        public Task<IEnumerable<InstructorDTO>> GetListInstructor();
        public Task<InstructorDetailDTO> GetInstructorDetailById(int instructorId);

    }
}
