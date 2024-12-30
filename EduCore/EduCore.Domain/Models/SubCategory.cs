using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        public string Name { get; set; } = null!;

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
