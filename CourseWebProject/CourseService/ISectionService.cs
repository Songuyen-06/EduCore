using CourseDomain;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public interface ISectionService

    {
        public Task<List<SectionDTO>> GetListSectionByCourseId(int courseId);
    }
}
