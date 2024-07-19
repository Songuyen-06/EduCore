using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public class InstructorDTO : UserDTO
    {
        public Decimal Rating { get; set; }
        public int NumberStudent {  get; set; }

        public int NumberCourse {  get; set; }

        public List<SubCategoryDTO> SubCategories {  get; set; }


    }
}
