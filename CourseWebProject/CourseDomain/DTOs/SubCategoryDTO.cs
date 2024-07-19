using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public  class SubCategoryDTO
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
    }
}
